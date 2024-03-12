using ntaklive.GeneticAlgorithm.WinForms.DataAccess.Entities;

namespace ntaklive.GeneticAlgorithm.WinForms.ExcelExport;

public interface IAttemptedRunExcelExporter
{
    void ExportAttemptedRunExcel(AttemptedRun attemptedRun, string fileName);
}
