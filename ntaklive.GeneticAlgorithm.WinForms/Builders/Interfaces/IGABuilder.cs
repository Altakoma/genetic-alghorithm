using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Fitnesses;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

internal interface IGABuilder
{
    ICrossover Crossover { get; }
    IMutation Mutation { get; }
    ISelection Selection { get; }
    IFitness Fitness { get; }
    IPopulation Population { get; }

    void BuildMutation(IMutationBuilder builder);
    void BuildCrossover(ICrossoverBuilder builder);
    void BuildSelection(ISelectionBuilder builder);
    void BuildFitness(IFitnessBuilder builder, int numberOfCities);
    void BuildPopulation(IPopulationBuilder builder, int minSize, int maxSize, IChromosome chromosome);

    global::GeneticSharp.Domain.GeneticAlgorithm Build();
}
