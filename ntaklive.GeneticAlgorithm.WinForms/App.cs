using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace ntaklive.GeneticAlgorithm.WinForms;

public static class App
{
    public static string SelectedWorksheet { get; internal set; }
    public static int MatrixSize { get; internal set; }
    public static int MatrixX { get; internal set; }
    public static int MatrixY { get; internal set; }
    public static int PopulationMin { get; internal set; }
    public static int PopulationMax { get; internal set; }
    public static int GenerationsNumber { get; internal set; }

    public static Dictionary<(int y, int x), int> Distances { get; internal set; }

    public static void SaveState()
    {
        var state = new AppState()
        {
            GenerationsNumber = App.GenerationsNumber,
            MatrixSize = App.MatrixSize,
            MatrixX = App.MatrixX,
            MatrixY = App.MatrixY,
            PopulationMax = App.PopulationMax,
            PopulationMin = App.PopulationMin
        };
        
        File.WriteAllText(Path.Combine(CurrentDirectoryPath, "state.json"), JsonSerializer.Serialize(state));
    }

    public static void LoadState()
    {
        string json = File.ReadAllText(Path.Combine(CurrentDirectoryPath, "state.json"));
        var state = JsonSerializer.Deserialize<AppState>(json);

        App.GenerationsNumber = state.GenerationsNumber;
        App.MatrixSize = state.MatrixSize;
        App.MatrixX = state.MatrixX;
        App.MatrixY = state.MatrixY;
        App.PopulationMax = state.PopulationMax;
        App.PopulationMin = state.PopulationMin;
    }
    
    public static int GetDistanceBetween(int fromId, int toId)
    {
        return Distances[new ValueTuple<int, int>(toId, fromId)];
    }
    
    internal class AppState
    {
        public int MatrixSize { get; set; }
        public int MatrixX { get; set; }
        public int MatrixY { get; set; }
        public int PopulationMin { get; set; }
        public int PopulationMax { get; set; }
        public int GenerationsNumber { get; set; }
    }
    
    public static readonly string CurrentDirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
}