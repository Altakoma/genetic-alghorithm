using GeneticSharp.Domain.Selections;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Selection;

public class StochasticUniversalSamplingSelectionBuilder : ISelectionBuilder
{
    public ISelection Build()
    {
        return new StochasticUniversalSamplingSelection();
    }
}
