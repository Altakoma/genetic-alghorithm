using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;
using ntaklive.GeneticAlgorithm.WinForms.GeneticSharp;
using ntaklive.GeneticAlgorithm.WinForms.Services;
// ReSharper disable LocalizableElement

namespace ntaklive.GeneticAlgorithm.WinForms;

public partial class MainForm : Form
{
    public static readonly object Lock = new();
    
    public MainForm()
    {
        InitializeComponent();
    }

    private void worksheetDropDown_DropDown(object sender, EventArgs e)
    {
        IWorkbookService workbookService = new WorkbookService();

        ICollection<WorksheetComboItem> worksheets = workbookService.GetWorksheetNamesFromActiveExcelWorkbook()
            .Select((x, i) => new WorksheetComboItem {Id = i, Text = x}).ToArray();

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
        var thread = new Thread((startButton) =>
        {
            var button = (startButton as Button)!;
            
            try
            {
                button.Enabled = false;

                ClearLog();

                IMatrixParser matrixParser = new MatrixParser();

                LogInformation("Загрузка расстояний...");

                App.Distances = matrixParser.ParseMatrixFromActiveExcelWorkbook(App.SelectedWorksheet,
                    new Point(App.MatrixX, App.MatrixY), App.MatrixSize);

                var selection = new EliteSelection();
                var crossover = new OrderedCrossover();
                var mutation = new ReverseSequenceMutation();
                var fitness = new MyFitness(App.MatrixSize);

                var chromosome = new MyChromosome(App.MatrixSize);
                var population = new TplPopulation(App.PopulationMin, App.PopulationMax, chromosome);

                var ga = new global::GeneticSharp.Domain.GeneticAlgorithm(population, fitness, selection, crossover,
                    mutation);
                ga.Termination = new GenerationNumberTermination(App.GenerationsNumber);
                ga.OperatorsStrategy = new TplOperatorsStrategy();

                LogInformation("Генетический алгоритм запущен...");

                Task.Delay(200).GetAwaiter().GetResult();

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
        }){Priority = ThreadPriority.Highest};
        

        thread.Start(startGAButton);
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
}