namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates Params Collections in C# 13/.NET 10
/// Params can now be used with any collection type implementing IEnumerable
/// </summary>
public static class ParamsCollectionsExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Params Collections Example ===");
        
        // Traditional params with array
        Console.WriteLine("Sum of 1, 2, 3: " + SumArray(1, 2, 3));
        
        // Params with List
        Console.WriteLine("Average of 10, 20, 30, 40: " + AverageList(10, 20, 30, 40));
        
        // Params with ReadOnlySpan
        Console.WriteLine("Max of 5, 15, 8, 23, 4: " + MaxSpan(5, 15, 8, 23, 4));
        
        // No arguments - empty collection
        Console.WriteLine("Sum of empty: " + SumArray());
        
        // Combining regular parameters with params
        DisplayItems("My Items", "Apple", "Banana", "Cherry");
    }
    
    // Traditional params with array
    private static int SumArray(params int[] numbers)
    {
        return numbers.Sum();
    }
    
    // Params with List<T>
    private static double AverageList(params List<int> numbers)
    {
        return numbers.Count > 0 ? numbers.Average() : 0;
    }
    
    // Params with ReadOnlySpan<T> for better performance
    private static int MaxSpan(params ReadOnlySpan<int> numbers)
    {
        if (numbers.Length == 0) return 0;
        
        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max) max = num;
        }
        return max;
    }
    
    // Combining regular parameter with params
    private static void DisplayItems(string title, params string[] items)
    {
        Console.WriteLine($"{title}:");
        foreach (var item in items)
        {
            Console.WriteLine($"  - {item}");
        }
    }
}
