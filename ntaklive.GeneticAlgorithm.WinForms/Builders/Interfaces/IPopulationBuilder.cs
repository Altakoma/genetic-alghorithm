using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Populations;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

public interface IPopulationBuilder
{
    IPopulation Build(int minSize, int maxSize, IChromosome chromosome);
}
