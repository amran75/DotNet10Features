namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates Inline Arrays in C# 12/.NET 10
/// Inline arrays allow efficient fixed-size array allocations on the stack
/// </summary>
public static class InlineArraysExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Inline Arrays Example ===");
        
        // Using inline array for buffer
        var buffer = new Buffer10<int>();
        
        // Fill the buffer
        for (int i = 0; i < 10; i++)
        {
            buffer[i] = i * 10;
        }
        
        // Read from buffer
        Console.Write("Buffer contents: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{buffer[i]} ");
        }
        Console.WriteLine();
        
        // Using with Span
        Span<int> span = buffer;
        Console.WriteLine($"Sum of buffer: {CalculateSum(span)}");
        
        // String buffer example
        var charBuffer = new Buffer10<char>();
        string text = "Hello!";
        for (int i = 0; i < text.Length && i < 10; i++)
        {
            charBuffer[i] = text[i];
        }
        
        Console.Write("Char buffer: ");
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(charBuffer[i]);
        }
        Console.WriteLine();
    }
    
    private static int CalculateSum(Span<int> values)
    {
        int sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }
        return sum;
    }
}

// Inline array struct with 10 elements
[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer10<T>
{
    private T _element0;
}
