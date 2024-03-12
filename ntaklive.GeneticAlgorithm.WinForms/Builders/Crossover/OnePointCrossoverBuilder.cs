using GeneticSharp.Domain.Crossovers;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Crossover;

internal class OnePointCrossoverBuilder : ICrossoverBuilder
{
    public ICrossover Build()
    {
        return new OnePointCrossover();
    }
}
