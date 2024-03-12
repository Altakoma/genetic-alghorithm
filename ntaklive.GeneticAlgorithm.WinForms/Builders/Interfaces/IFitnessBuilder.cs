using GeneticSharp.Domain.Fitnesses;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

public interface IFitnessBuilder
{
    IFitness Build(int numberOfCities);
}
