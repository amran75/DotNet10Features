namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates Default Lambda Parameters in C# 12/.NET 10
/// Lambda expressions can now have default parameter values
/// </summary>
public static class DefaultLambdaParametersExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Default Lambda Parameters Example ===");
        
        // Lambda with default parameter
        var greet = (string name = "Guest") => $"Hello, {name}!";
        
        Console.WriteLine(greet());           // Uses default: "Guest"
        Console.WriteLine(greet("Alice"));    // Uses provided: "Alice"
        
        // Multiple parameters with defaults
        var calculateTotal = (decimal price, decimal tax = 0.10m, decimal discount = 0m) =>
        {
            var subtotal = price + (price * tax);
            return subtotal - discount;
        };
        
        Console.WriteLine($"Total (no tax/discount specified): ${calculateTotal(100):F2}");
        Console.WriteLine($"Total (with custom tax): ${calculateTotal(100, 0.15m):F2}");
        Console.WriteLine($"Total (with tax and discount): ${calculateTotal(100, 0.15m, 10m):F2}");
        
        // Using in LINQ-like scenarios
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        
        var filter = (int number, int threshold = 5) => number > threshold;
        var filteredNumbers = numbers.Where(n => filter(n)).ToList();
        
        Console.WriteLine($"Numbers > 5: [{string.Join(", ", filteredNumbers)}]");
    }
}
