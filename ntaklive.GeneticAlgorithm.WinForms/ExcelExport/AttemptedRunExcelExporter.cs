using FastExcel;
using ntaklive.GeneticAlgorithm.WinForms.DataAccess.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Theraot.Collections;

namespace ntaklive.GeneticAlgorithm.WinForms.ExcelExport;

internal class AttemptedRunExcelExporter : IAttemptedRunExcelExporter
{
    public void ExportAttemptedRunExcel(AttemptedRun attemptedRun, string fileName)
    {
        using (FastExcel.FastExcel fastExcel =
            new(new FileInfo(fileName)))
        {
            List<Row> rows = new List<Row>();

            int count = 0;
            int column = 0;
            int namesColumn = 0;

            var existingWorksheet = fastExcel.Read(1);

            if (existingWorksheet is not null && existingWorksheet.Rows.Count() >= 2)
            {
                rows = existingWorksheet.Rows.ToList();

                List<Cell> secondRow = existingWorksheet.Rows.Take(2).Last().Cells.ToList();

                while (secondRow.Count >= count + 7 &&
                       (secondRow[count].XElement.Value != string.Empty ||
                       secondRow[count].XElement.Value != null))
                {
                    count += 7;
                    column += 8;
                    namesColumn += 8;
                }
            }
            var worksheet = new Worksheet();

            count = (count / 7) + count;

            int headersCount = count + 2;

            var cellsHeaders = new List<Cell>
            {
                new(headersCount++, "GenerationCount"),
                new(headersCount++, "MinPopulation"),
                new(headersCount++, "MaxPopulation"),
                new(headersCount++, "TimeInSec"),
                new(headersCount++, "Fitness"),
                new(headersCount++, "Distance")
            };

            if (rows.Count() == 0)
            {
                rows.Add(new Row(1, cellsHeaders));
            }
            else
            {
                var locCells = rows[0].Cells.ToList();

                locCells.AddRange(cellsHeaders);
                rows[0].Cells = locCells;
            }

            string[] names = new string[]
            {
                attemptedRun.Mutation,
                attemptedRun.Selection,
                attemptedRun.Crossover,
                attemptedRun.Fitness,
                attemptedRun.Chromosome,
                attemptedRun.Population
            };

            column += 2;
            namesColumn += 1;

            for (int rowNumber = 2; rowNumber <= ((attemptedRun.NumericalIndicators.Count + 2) >= 7 ? attemptedRun.NumericalIndicators.Count + 2 : 7); rowNumber++)
            {
                var cells = new List<Cell>();

                if (rows.ElementAtOrDefault(rowNumber) == null)
                {
                    rows.Add(new Row(rowNumber, new List<Cell>()));
                }

                var localCells = rows[rowNumber - 1].Cells.ToList();

                if (names.Length > rowNumber - 2)
                {
                    cells.Add(new Cell(namesColumn, names[rowNumber - 2]));
                }

                if (attemptedRun.NumericalIndicators.Count + 2 > rowNumber)
                {
                    cells.Add(new Cell(column++, attemptedRun.NumericalIndicators[rowNumber - 2].GenerationCount));
                    cells.Add(new Cell(column++, attemptedRun.NumericalIndicators[rowNumber - 2].MinPopulation));
                    cells.Add(new Cell(column++, attemptedRun.NumericalIndicators[rowNumber - 2].MaxPopulation));
                    cells.Add(new Cell(column++, attemptedRun.NumericalIndicators[rowNumber - 2].TimeInSec));
                    cells.Add(new Cell(column++, attemptedRun.NumericalIndicators[rowNumber - 2].Fintess));
                    cells.Add(new Cell(column++, attemptedRun.NumericalIndicators[rowNumber - 2].Distance));

                    column -= 6;
                }

                foreach (var cell in cells)
                {
                    localCells.Add(cell);
                }

                rows[rowNumber - 1].Cells = localCells;
            }

            if (existingWorksheet is not null)
            {
                existingWorksheet.Rows = rows;
                fastExcel.Write(existingWorksheet, 1);
            }
            else
            {
                worksheet.Rows = rows;
                fastExcel.Write(existingWorksheet, 1);
            }
        }
    }
}
