using GeneticSharp.Domain.Crossovers;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Crossover
{
    internal class PositionBasedCrossoverBuilder : ICrossoverBuilder
    {
        public ICrossover Build()
        {
            return new PositionBasedCrossover();
        }
    }
}
