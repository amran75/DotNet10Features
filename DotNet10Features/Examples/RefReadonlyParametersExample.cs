namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates ref readonly parameters in C# 12/.NET 10
/// Allows passing parameters by reference without allowing modifications
/// </summary>
public static class RefReadonlyParametersExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Ref Readonly Parameters Example ===");
        
        // Large struct that benefits from ref readonly
        var largeStruct = new LargeStruct
        {
            Id = 1,
            Name = "Large Data Structure",
            Data = new int[100]
        };
        
        // Fill data
        for (int i = 0; i < largeStruct.Data.Length; i++)
        {
            largeStruct.Data[i] = i;
        }
        
        // Pass by ref readonly - no copy, no modification
        ProcessStruct(in largeStruct);
        
        Console.WriteLine($"Original struct ID: {largeStruct.Id}");
        Console.WriteLine($"Original struct Name: {largeStruct.Name}");
        
        // Performance comparison
        var point = new Vector3D { X = 10, Y = 20, Z = 30 };
        
        Console.WriteLine("\nPassing by value (creates copy):");
        ProcessByValue(point);
        
        Console.WriteLine("\nPassing by ref readonly (no copy):");
        ProcessByRefReadonly(in point);
    }
    
    private static void ProcessStruct(ref readonly LargeStruct data)
    {
        // Can read data without copying the entire structure
        Console.WriteLine($"Processing struct with ID: {data.Id}");
        Console.WriteLine($"Data array length: {data.Data.Length}");
        Console.WriteLine($"Sum of first 10 elements: {data.Data.Take(10).Sum()}");
        
        // Attempting to modify would cause a compiler error:
        // data.Id = 2; // Error: Cannot modify ref readonly variable
    }
    
    private static void ProcessByValue(Vector3D point)
    {
        Console.WriteLine($"  Point: ({point.X}, {point.Y}, {point.Z})");
        // This creates a copy of the struct
    }
    
    private static void ProcessByRefReadonly(ref readonly Vector3D point)
    {
        Console.WriteLine($"  Point: ({point.X}, {point.Y}, {point.Z})");
        // This doesn't create a copy but prevents modification
    }
}

public struct LargeStruct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int[] Data { get; set; }
}

public struct Vector3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
}
