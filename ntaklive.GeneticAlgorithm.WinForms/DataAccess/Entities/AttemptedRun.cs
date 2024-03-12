using System.Collections.Generic;

namespace ntaklive.GeneticAlgorithm.WinForms.DataAccess.Entities;

public class AttemptedRun
{
    public string Mutation { get; set; }
    public string Selection { get; set; }
    public string Crossover { get; set; }
    public string Fitness { get; set; }
    public string Chromosome { get; set; }
    public string Population { get; set; }

    public List<NumericalIndicators> NumericalIndicators { get; set; }

    public string GetFileName()
    {
        return Selection + Mutation + Crossover;
    }
}
