namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates Collection Expressions in C# 12/.NET 10
/// Collection expressions provide a concise syntax for creating collections
/// </summary>
public static class CollectionExpressionsExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Collection Expressions Example ===");
        
        // Array initialization with collection expressions
        int[] numbers = [1, 2, 3, 4, 5];
        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        
        // List initialization
        List<string> fruits = ["Apple", "Banana", "Orange", "Mango"];
        Console.WriteLine($"List: [{string.Join(", ", fruits)}]");
        
        // Spread operator (..) to combine collections
        int[] moreNumbers = [6, 7, 8];
        int[] combined = [..numbers, ..moreNumbers];
        Console.WriteLine($"Combined with spread: [{string.Join(", ", combined)}]");
        
        // Mix elements and spreads
        string[] moreFruits = ["Grape", "Pear"];
        List<string> allFruits = ["Strawberry", ..fruits, "Kiwi", ..moreFruits];
        Console.WriteLine($"Mixed fruits: [{string.Join(", ", allFruits)}]");
        
        // Empty collection
        int[] empty = [];
        Console.WriteLine($"Empty collection: [{string.Join(", ", empty)}]");
        
        // With Span<T>
        Span<int> span = [10, 20, 30, 40];
        Console.WriteLine($"Span: [{string.Join(", ", span.ToArray())}]");
    }
}
