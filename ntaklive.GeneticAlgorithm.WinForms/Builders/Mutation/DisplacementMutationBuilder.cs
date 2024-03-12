using GeneticSharp.Domain.Mutations;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Mutation;

public class DisplacementMutationBuilder : IMutationBuilder
{
    public IMutation Build()
    {
        return new DisplacementMutation();
    }
}
