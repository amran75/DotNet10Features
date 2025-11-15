namespace DotNet10Features.Examples;

// Alias for tuple type
using Point2D = (double X, double Y);
using Point3D = (double X, double Y, double Z);

// Alias for array type
using StringArray = string[];
using IntMatrix = int[][];

// Alias for complex generic type
using StringDictionary = System.Collections.Generic.Dictionary<string, string>;
using PersonList = System.Collections.Generic.List<(string Name, int Age)>;

/// <summary>
/// Demonstrates Alias Any Type feature in C# 12/.NET 10
/// You can now create aliases for any type including tuples, arrays, and pointers
/// </summary>
public static class AliasAnyTypeExample
{
    
    public static void Run()
    {
        Console.WriteLine("\n=== Alias Any Type Example ===");
        
        // Using tuple aliases
        Point2D point2D = (10.5, 20.3);
        Console.WriteLine($"2D Point: X={point2D.X}, Y={point2D.Y}");
        
        Point3D point3D = (5.0, 10.0, 15.0);
        Console.WriteLine($"3D Point: X={point3D.X}, Y={point3D.Y}, Z={point3D.Z}");
        
        // Using array aliases
        StringArray fruits = ["Apple", "Banana", "Orange"];
        Console.WriteLine($"Fruits: {string.Join(", ", fruits)}");
        
        IntMatrix matrix = 
        [
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        ];
        Console.WriteLine("Matrix:");
        foreach (var row in matrix)
        {
            Console.WriteLine($"  [{string.Join(", ", row)}]");
        }
        
        // Using dictionary alias
        StringDictionary config = new()
        {
            ["AppName"] = "DotNet10Features",
            ["Version"] = "1.0",
            ["Author"] = "Demo"
        };
        Console.WriteLine("Configuration:");
        foreach (var kvp in config)
        {
            Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
        }
        
        // Using complex type alias
        PersonList people = 
        [
            ("Alice", 30),
            ("Bob", 25),
            ("Charlie", 35)
        ];
        Console.WriteLine("People:");
        foreach (var person in people)
        {
            Console.WriteLine($"  {person.Name}, Age: {person.Age}");
        }
    }
}
