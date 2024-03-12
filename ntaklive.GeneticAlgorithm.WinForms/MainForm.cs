using GeneticSharp.Domain;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Terminations;
using ntaklive.GeneticAlgorithm.WinForms.Builders;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Crossover;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Fitness;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Mutation;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Population;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Selection;
using ntaklive.GeneticAlgorithm.WinForms.DataAccess.Entities;
using ntaklive.GeneticAlgorithm.WinForms.ExcelExport;
using ntaklive.GeneticAlgorithm.WinForms.GeneticSharp;
using ntaklive.GeneticAlgorithm.WinForms.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ntaklive.GeneticAlgorithm.WinForms;

public partial class MainForm : Form
{
    public static readonly object Lock = new();

    private static string s_path;
    private static string s_excel_file_path;

    public MainForm()
    {
        InitializeComponent();
    }

    private void worksheetDropDown_DropDown(object sender, EventArgs e)
    {
        IWorkbookService workbookService = new WorkbookService();

        ICollection<WorksheetComboItem> worksheets = workbookService.GetWorksheetNamesFromActiveExcelWorkbook()
            .Select((x, i) => new WorksheetComboItem { Id = i, Text = x }).ToArray();

        var dropDown = (sender as ComboBox)!;
        dropDown.DataSource = worksheets;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            App.LoadState();

            matrixSizeTextBox.Text = App.MatrixSize.ToString();
            populationMinValueTextBox.Text = App.PopulationMin.ToString();
            populationMaxValueTextBox.Text = App.PopulationMax.ToString();
            generationsNumberTextBox.Text = App.GenerationsNumber.ToString();
            matrixPointXValueTextBox.Text = App.MatrixX.ToString();
            matrixPointYValueTextBox.Text = App.MatrixY.ToString();

            LogInformation("Предыдущие настройки были восстановлены");
        }
        catch
        {
            LogInformation("Не удалось восстановить предыдущие настройки");
            // ignore
        }

        worksheetDropDown_DropDown(worksheetComboBox, EventArgs.Empty);
    }

    private void startGAButton_Click(object sender, EventArgs e)
    {
        if (single.Checked)
        {
            Evaluate();
        }
        else if (many.Checked)
        {
            EvaluateAndExport();
        }
    }

    private void Evaluate()
    {
        var thread = new Thread((startButton) =>
        {
            var button = (startButton as Button)!;

            Invoke((MethodInvoker)delegate
            {
                try
                {
                    button.Enabled = false;

                    ClearLog();

                    IMatrixParser matrixParser = new MatrixParser();

                    LogInformation("Загрузка расстояний...");

                    App.Distances = matrixParser.ParseMatrixFromActiveExcelWorkbook(App.SelectedWorksheet,
                        new Point(App.MatrixX, App.MatrixY), App.MatrixSize);

                    var ga = GetSelectedGACombination(
                        App.PopulationMin,
                        App.PopulationMax,
                        new MyChromosome(App.MatrixSize),
                        App.MatrixSize);

                    ga.Termination = new GenerationNumberTermination(App.GenerationsNumber);
                    ga.OperatorsStrategy = new TplOperatorsStrategy();

                    LogInformation("Генетический алгоритм запущен...");

                    ga.Start();

                    LogInformation("Генетический алгоритм успешно завершен...");
                    LogInformation("");

                    var bestChromosome = (ga.BestChromosome as MyChromosome)!;
                    string bestChromosomeRepresentation = bestChromosome.GetGenes()
                        .Select(x => (Convert.ToInt32(x.Value) + 1).ToString()).Aggregate((i1, i2) => $"{i1} {i2}");

                    LogInformation($"Поколения: {ga.Population.GenerationsNumber}");
                    LogInformation($"Пригодность: {bestChromosome.Fitness,10}");
                    LogInformation($"Затраченное время на поиск: {ga.TimeEvolving}");
                    LogInformation(
                        $"Скорость (поколений/сек): {ga.Population.GenerationsNumber / ga.TimeEvolving.TotalSeconds:0.0000}");

                    LogInformation("Лучшее решение: ");
                    LogInformation($"Расстояние: {bestChromosome.Distance}");
                    LogInformation($"Очередь: {bestChromosomeRepresentation}");
                }
                catch (Exception exception)
                {
                    LogException(exception);
                }
                finally
                {
                    button.Enabled = true;
                }
            });
        })
        { Priority = ThreadPriority.Highest };


        thread.Start(startGAButton);
    }

    private void EvaluateAndExport()
    {
        var thread = new Thread((startButton) =>
        {
            var button = (startButton as Button)!;

            Invoke((MethodInvoker)delegate
            {
                try
                {
                    button.Enabled = false;

                    ClearLog();

                    IMatrixParser matrixParser = new MatrixParser();

                    App.Distances = matrixParser.ParseMatrixFromActiveExcelWorkbook(App.SelectedWorksheet,
                        new Point(App.MatrixX, App.MatrixY), App.MatrixSize);

                    var attemptedRun = new AttemptedRun()
                    {
                        NumericalIndicators = new List<NumericalIndicators>(
                                                    (populationsTable.Rows.Count - 1) *
                                                    (generationsCountTable.Rows.Count - 1)),
                    };

                    int attemptCounter = 0;

                    var populationRows = populationsTable.Rows;
                    var generationsCountRows = generationsCountTable.Rows;
                    int iteration = 0;

                    for (int i = 0; i < populationRows.Count - 1; i++)
                    {
                        for (int k = 0; k < generationsCountRows.Count - 1; k++)
                        {
                            int repeatsCount = int.Parse(generationsCountRows[k].Cells[1].Value.ToString());

                            for (int c = 0; c < repeatsCount; c++)
                            {
                                var ga = GetSelectedGACombination(
                                int.Parse(populationRows[i].Cells[0].Value.ToString()),
                                int.Parse(populationRows[i].Cells[1].Value.ToString()),
                                new MyChromosome(App.MatrixSize),
                                App.MatrixSize);

                                ga.Termination = new GenerationNumberTermination(int.Parse(generationsCountRows[k].Cells[0].Value.ToString()));
                                ga.OperatorsStrategy = new TplOperatorsStrategy();

                                ga.Start();

                                if (i == 0 && k == 0)
                                {
                                    attemptedRun.Mutation = ga.Mutation.GetType().Name;
                                    attemptedRun.Crossover = ga.Crossover.GetType().Name;
                                    attemptedRun.Selection = ga.Selection.GetType().Name;
                                    attemptedRun.Population = ga.Population.GetType().Name;
                                    attemptedRun.Chromosome = ga.Population.BestChromosome.GetType().Name;
                                    attemptedRun.Fitness = ga.Fitness.GetType().Name;
                                }

                                var bestChromosome = (ga.BestChromosome as MyChromosome)!;

                                attemptedRun.NumericalIndicators.Add(
                                    new NumericalIndicators
                                    {
                                        GenerationCount = int.Parse(generationsCountRows[k].Cells[0].Value.ToString()),
                                        MaxPopulation = int.Parse(populationRows[i].Cells[1].Value.ToString()),
                                        MinPopulation = int.Parse(populationRows[i].Cells[0].Value.ToString()),
                                        TimeInSec = ga.TimeEvolving.TotalSeconds,
                                        Fintess = (double)bestChromosome.Fitness,
                                        Distance = bestChromosome.Distance
                                    });
                            }
                        }
                    }

                    if (jsonExportMode.Checked)
                    {
                        string jsonString = JsonSerializer.Serialize(attemptedRun, new JsonSerializerOptions { WriteIndented = true });

                        System.IO.File.WriteAllText(s_path + @"\" + attemptedRun.GetFileName() +
                                                    Regex.Replace(DateTime.UtcNow.ToString(), @"[-.: ]", string.Empty)
                                                    + ".json", jsonString);
                    }
                    else
                    {
                        var exporter = new AttemptedRunExcelExporter();

                        exporter.ExportAttemptedRunExcel(attemptedRun, s_excel_file_path);
                    }

                    LogInformation("Отчёты сохранены в файл");
                }
                catch (Exception exception)
                {
                    LogException(exception);
                }
                finally
                {
                    button.Enabled = true;
                }
            });
        })
        { Priority = ThreadPriority.Highest };


        thread.Start(startGAButton);
    }

    private global::GeneticSharp.Domain.GeneticAlgorithm GetSelectedGACombination(
        int minSize,
        int maxSize,
        IChromosome chromosome,
        int numberOfOrders)
    {
        ISelectionBuilder selectionBuilder = Enum.Parse(typeof(Selections), selectionsBox.Controls.OfType<RadioButton>()
                                   .Where(button => button.Checked)
                                   .First().Text) switch
        {
            Selections.Elite => new EliteSelectionBuilder(),
            Selections.RouletteWheel => new RouletteWheelSelectionBuilder(),
            Selections.StochasticUniversalSampling => new StochasticUniversalSamplingSelectionBuilder(),
            Selections.Tournament => new TournamentSelectiionBuilder(),
            _ => throw new ArgumentException(),
        };

        IMutationBuilder mutationBuilder = Enum.Parse(typeof(Mutations), mutationsBox.Controls.OfType<RadioButton>()
                                   .Where(button => button.Checked)
                                   .First().Text) switch
        {
            Mutations.Displacement => new DisplacementMutationBuilder(),
            Mutations.Insertion => new InsertionMutationBuilder(),
            Mutations.ReverseSequence => new ReverseSequenceMutationBuilder(),
            Mutations.Twors => new TworsMutationBuilder(),
            _ => throw new ArgumentException(),
        };

        ICrossoverBuilder crossoverBuilder = Enum.Parse(typeof(Crossovers), crossoversBox.Controls.OfType<RadioButton>()
                                   .Where(button => button.Checked)
                                   .First().Text) switch
        {
            Crossovers.Cycle => new CycleCrossoverBuilder(),
            Crossovers.OnePoint => new OnePointCrossoverBuilder(),
            Crossovers.OrderBased => new OrderBasedCrossoverBuilder(),
            Crossovers.Ordered => new OrderedCrossoverBuilder(),
            Crossovers.PartiallyMapped => new PartiallyMappedCrossoverBuilder(),
            Crossovers.PositionBased => new PositionBasedCrossoverBuilder(),
            Crossovers.ThreeParent => new ThreeParentCrossoverBuilder(),
            Crossovers.TwoPoint => new TwoPointCrossoverBuilder(),
            Crossovers.Uniform => new UniformCrossoverBuilder(),
            _ => throw new ArgumentException(),
        };

        IPopulationBuilder populationBuilder = Enum.Parse(typeof(Populations), populationsBox.Controls.OfType<RadioButton>()
                                   .Where(button => button.Checked)
                                   .First().Text) switch
        {
            Populations.TPLPopulation => new TPLPopulationBuilder(),
            _ => throw new ArgumentException(),
        };

        IFitnessBuilder fitnessBuilder = Enum.Parse(typeof(Fitnesses), fitnessesBox.Controls.OfType<RadioButton>()
                                   .Where(button => button.Checked)
                                   .First().Text) switch
        {
            Fitnesses.MyFitness => new MyFitnessBuilder(),
            _ => throw new ArgumentException(),
        };

        IGABuilder gaBuilder = new GABuilder();

        gaBuilder.BuildMutation(mutationBuilder);
        gaBuilder.BuildCrossover(crossoverBuilder);
        gaBuilder.BuildSelection(selectionBuilder);
        gaBuilder.BuildPopulation(populationBuilder, minSize, maxSize, chromosome);
        gaBuilder.BuildFitness(fitnessBuilder, numberOfOrders);

        return gaBuilder.Build();
    }

    private void generationsNumberTextBox_TextChanged(object sender, EventArgs e)
    {
        var control = (sender as TextBox)!;

        if (int.TryParse(control.Text, out int value))
        {
            App.GenerationsNumber = value;
        }
        else
        {
            resultValueRichTextBox.Text = "Неверно указано количество поколений";
        }
    }

    private void worksheetComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var control = (sender as ComboBox)!;

        App.SelectedWorksheet = (control.DataSource as ICollection<WorksheetComboItem>)!.First(x => x.Id ==
            (control.SelectedItem as WorksheetComboItem)!.Id).Text;
    }

    private void matrixSizeTextBox_TextChanged(object sender, EventArgs e)
    {
        var control = (sender as TextBox)!;

        if (int.TryParse(control.Text, out int value))
        {
            App.MatrixSize = value;
        }
        else
        {
            resultValueRichTextBox.Text = "Неверно указан размер матрицы";
        }
    }

    private void matrixPointXValueTextBox_TextChanged(object sender, EventArgs e)
    {
        var control = (sender as TextBox)!;

        if (int.TryParse(control.Text, out int value))
        {
            App.MatrixX = value;
        }
        else
        {
            resultValueRichTextBox.Text = "Неверно указана точка X матрицы";
        }
    }

    private void matrixPointYValueTextBox_TextChanged(object sender, EventArgs e)
    {
        var control = (sender as TextBox)!;

        if (int.TryParse(control.Text, out int value))
        {
            App.MatrixY = value;
        }
        else
        {
            resultValueRichTextBox.Text = "Неверно указана точка Y матрицы";
        }
    }

    private void populationMinValueTextBox_TextChanged(object sender, EventArgs e)
    {
        var control = (sender as TextBox)!;

        if (int.TryParse(control.Text, out int value))
        {
            App.PopulationMin = value;
        }
        else
        {
            resultValueRichTextBox.Text = "Неверно указано минимальное значение размера популяции";
        }
    }

    private void populationMaxValueTextBox_TextChanged(object sender, EventArgs e)
    {
        var control = (sender as TextBox)!;

        if (int.TryParse(control.Text, out int value))
        {
            App.PopulationMax = value;
        }
        else
        {
            resultValueRichTextBox.Text = "Неверно указано максимальное значение размера популяции";
        }
    }

    private void LogInformation(string message)
    {
        lock (Lock)
        {
            resultValueRichTextBox.Text = resultValueRichTextBox.Text += $"({DateTime.Now.ToLongTimeString()}) [INF]: {message}\n";
        }
    }

    private void LogException(Exception exception)
    {
        lock (Lock)
        {
            resultValueRichTextBox.Text = resultValueRichTextBox.Text += $"({DateTime.Now.ToLongTimeString()}) [ERR]: {exception}\n";
        }
    }

    private void ClearLog()
    {
        resultValueRichTextBox.Text = string.Empty;
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        App.SaveState();
    }

    private class WorksheetComboItem
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    private void many_CheckedChanged(object sender, EventArgs e)
    {
        populationsTable.Visible = true;
        generationsCountTable.Visible = true;
        folderButton.Visible = true;
        folderLabel.Visible = true;
        exportTypeGroup.Visible = true;

        generationsLabel.Visible = false;
        generationsNumberTextBox.Visible = false;
        populationSizeLabel.Visible = false;
        minPopulationSizeLabel.Visible = false;
        maxPopulationSizeLabel.Visible = false;
        populationMinValueTextBox.Visible = false;
        populationMaxValueTextBox.Visible = false;
    }

    private void single_CheckedChanged(object sender, EventArgs e)
    {
        populationsTable.Visible = false;
        generationsCountTable.Visible = false;
        folderButton.Visible = false;
        folderLabel.Visible = false;
        exportTypeGroup.Visible = false;
        exportExcelButton.Visible = false;
        exportExcelLabel.Visible = false;

        generationsLabel.Visible = true;
        generationsNumberTextBox.Visible = true;
        populationSizeLabel.Visible = true;
        minPopulationSizeLabel.Visible = true;
        maxPopulationSizeLabel.Visible = true;
        populationMinValueTextBox.Visible = true;
        populationMaxValueTextBox.Visible = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        using (var dialog = new FolderBrowserDialog())
        {
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                s_path = dialog.SelectedPath;

                folderLabel.Text = s_path + @"\";
            }
        }
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void jsonExportMode_CheckedChanged(object sender, EventArgs e)
    {
        folderButton.Visible = true;
        folderLabel.Visible = true;
        exportExcelButton.Visible = false;
        exportExcelLabel.Visible = false;
    }

    private void excelMode_CheckedChanged(object sender, EventArgs e)
    {
        folderButton.Visible = false;
        folderLabel.Visible = false;
        exportExcelButton.Visible = true;
        exportExcelLabel.Visible = true;
    }

    private void exportExcelButton_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                s_excel_file_path = openFileDialog.FileName;

                exportExcelLabel.Text = s_excel_file_path;
            }
        }
    }
}