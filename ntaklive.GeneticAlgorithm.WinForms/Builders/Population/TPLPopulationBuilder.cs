using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Populations;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Population;

public class TPLPopulationBuilder : IPopulationBuilder
{
    public IPopulation Build(int minSize, int maxSize, IChromosome chromosome)
    {
        return new TplPopulation(minSize, maxSize, chromosome);
    }
}
