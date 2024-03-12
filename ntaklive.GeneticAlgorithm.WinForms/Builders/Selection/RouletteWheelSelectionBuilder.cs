﻿using GeneticSharp.Domain.Selections;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Selection;

public class RouletteWheelSelectionBuilder : ISelectionBuilder
{
    public ISelection Build()
    {
        return new RouletteWheelSelection();
    }
}
