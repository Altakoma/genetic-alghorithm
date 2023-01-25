using System;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Extensions.Tsp;

namespace ntaklive.GeneticAlgorithm.WinForms.GeneticSharp;

/// <summary>
///     Travelling Salesman Problem chromosome.
///     <remarks>
///         Each gene represents a city index.
///     </remarks>
/// </summary>
[Serializable]
public class MyChromosome : ChromosomeBase
{
    #region Fields

    private readonly int m_numberOfCities;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="TspChromosome" /> class.
    /// </summary>
    /// <param name="numberOfCities">Number of cities.</param>
    public MyChromosome(int numberOfCities) : base(numberOfCities)
    {
        m_numberOfCities = numberOfCities;

        for (var i = 0; i < numberOfCities; i++)
        {
            ReplaceGene(i, new Gene(i));
        }
    }

    #endregion

    #region Properties

    /// <summary>
    ///     Gets the distance.
    /// </summary>
    /// <value>The distance.</value>
    public double Distance { get; internal set; }

    #endregion

    #region implemented abstract members of ChromosomeBase

    public static int previousOrderId = 0;
    
    /// <summary>
    ///     Generates the gene for the specified index.
    /// </summary>
    /// <returns>The gene.</returns>
    /// <param name="geneIndex">Gene index.</param>
    public override Gene GenerateGene(int geneIndex)
    {
        return new Gene(previousOrderId++);
    }

    /// <summary>
    ///     Creates a new chromosome using the same structure of this.
    /// </summary>
    /// <returns>The new chromosome.</returns>
    public override IChromosome CreateNew()
    {
        return new MyChromosome(m_numberOfCities);
    }

    /// <summary>
    ///     Creates a clone.
    /// </summary>
    /// <returns>The chromosome clone.</returns>
    public override IChromosome Clone()
    {
        var clone = base.Clone() as MyChromosome;
        clone.Distance = Distance;

        return clone;
    }

    #endregion
}