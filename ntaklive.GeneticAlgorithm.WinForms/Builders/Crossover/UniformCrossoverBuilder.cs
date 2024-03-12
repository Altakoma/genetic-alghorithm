using GeneticSharp.Domain.Crossovers;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Crossover;

public class UniformCrossoverBuilder : ICrossoverBuilder
{
    public ICrossover Build()
    {
        return new UniformCrossover();
    }
}
