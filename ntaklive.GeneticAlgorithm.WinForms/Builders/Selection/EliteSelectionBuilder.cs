﻿using GeneticSharp.Domain.Selections;
using ntaklive.GeneticAlgorithm.WinForms.Builders.Interfaces;

namespace ntaklive.GeneticAlgorithm.WinForms.Builders.Selection;

public class EliteSelectionBuilder : ISelectionBuilder
{
    public ISelection Build()
    {
        return new EliteSelection();
    }
}
