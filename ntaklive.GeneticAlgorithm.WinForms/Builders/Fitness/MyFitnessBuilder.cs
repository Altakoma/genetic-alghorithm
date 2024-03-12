using GeneticSharp.Domain.Fitnesses;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;
using ntaklive.GeneticAlgorithm.WinForms.GeneticSharp;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Fitness;

public class MyFitnessBuilder : IFitnessBuilder
{
    public IFitness Build(int numberOfCities)
    {
        return new MyFitness(numberOfCities);
    }
}
