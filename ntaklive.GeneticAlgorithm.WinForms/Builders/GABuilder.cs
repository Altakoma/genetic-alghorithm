using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Fitnesses;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders;

public class GABuilder : IGABuilder
{
    public ICrossover Crossover { get; set; }
    public IMutation Mutation { get; set; }
    public ISelection Selection { get; set; }
    public IPopulation Population { get; set; }
    public IFitness Fitness { get; set; }

    public global::GeneticSharp.Domain.GeneticAlgorithm Build()
    {
        return new global::GeneticSharp.Domain.GeneticAlgorithm(
            Population,
            Fitness,
            Selection,
            Crossover,
            Mutation);
    }

    public void BuildCrossover(ICrossoverBuilder builder)
    {
        Crossover = builder.Build();
    }

    public void BuildFitness(IFitnessBuilder builder, int numberOfCities)
    {
        Fitness = builder.Build(numberOfCities);
    }

    public void BuildMutation(IMutationBuilder builder)
    {
        Mutation = builder.Build();
    }

    public void BuildPopulation(IPopulationBuilder builder, int minSize, int maxSize, IChromosome chromosome)
    {
        Population = builder.Build(minSize, maxSize, chromosome);
    }

    public void BuildSelection(ISelectionBuilder builder)
    {
        Selection = builder.Build();
    }
}
