using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;
using GeneticSharp.Extensions.Tsp;

namespace ntaklive.GeneticAlgorithm.WinForms.GeneticSharp;

public class MyFitness : IFitness
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TspFitness" /> class.
    /// </summary>
    /// <param name="numberOfCities">The number of cities.</param>
    public MyFitness(int numberOfCities)
    {
        Orders = new List<TspOrder>(numberOfCities);

        for (var i = 0; i < numberOfCities; i++)
        {
            Orders.Add(new TspOrder(i));
        }
    }

    /// <summary>
    ///     Gets the cities.
    /// </summary>
    /// <value>The cities.</value>
    public IList<TspOrder> Orders { get; }

    /// <summary>
    ///     Performs the evaluation against the specified chromosome.
    /// </summary>
    /// <param name="chromosome">The chromosome to be evaluated.</param>
    /// <returns>The fitness of the chromosome.</returns>
    public double Evaluate(IChromosome chromosome)
    {
        Gene[]? genes = chromosome.GetGenes();
        var distanceSum = 0.0;
        var lastCityIndex = Convert.ToInt32(genes[0].Value, CultureInfo.InvariantCulture);
        var citiesIndexes = new List<int>
        {
            lastCityIndex
        };

        for (int i = 0, genesLength = genes.Length; i < genesLength; i++)
        {
            var currentCityIndex = Convert.ToInt32(genes[i].Value, CultureInfo.InvariantCulture);
            distanceSum += CalcDistanceTwoCities(Orders[currentCityIndex], Orders[lastCityIndex]);
            lastCityIndex = currentCityIndex;

            citiesIndexes.Add(lastCityIndex);
        }

        // distanceSum += CalcDistanceTwoCities(Orders[citiesIndexes.Last()], Orders[citiesIndexes.First()]);

        double fitness = 1.0 - distanceSum / (Orders.Count * 1000.0);

        ((MyChromosome) chromosome).Distance = distanceSum;

        // There is repeated cities on the indexes?
        int diff = Orders.Count - citiesIndexes.Distinct().Count();

        if (diff > 0)
        {
            fitness /= diff;
        }

        if (fitness < 0)
        {
            fitness = 0;
        }

        return fitness;
    }

    /// <summary>
    ///     Calculates the distance between two cities.
    /// </summary>
    /// <returns>The distance two cities.</returns>
    /// <param name="one">City one.</param>
    /// <param name="two">City two.</param>
    private static double CalcDistanceTwoCities(TspOrder one, TspOrder two)
    {
        return App.GetDistanceBetween(one.Id, two.Id);
    }
}