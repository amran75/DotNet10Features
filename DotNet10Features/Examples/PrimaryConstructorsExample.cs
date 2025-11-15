namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates Primary Constructors in C# 12/.NET 10
/// Primary constructors allow declaring constructor parameters directly in the class declaration
/// </summary>
public static class PrimaryConstructorsExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Primary Constructors Example ===");
        
        // Using a class with primary constructor
        var person = new Person("John Doe", 30);
        person.DisplayInfo();
        
        var employee = new Employee("Jane Smith", 28, "Engineering");
        employee.DisplayInfo();
        
        // Struct with primary constructor
        var point = new Point(10, 20);
        Console.WriteLine($"Point: {point}");
    }
}

// Class with primary constructor
public class Person(string name, int age)
{
    // Primary constructor parameters are available throughout the class
    public string Name { get; } = name;
    public int Age { get; } = age;
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Person: {Name}, Age: {Age}");
    }
}

// Inheritance with primary constructors
public class Employee(string name, int age, string department) : Person(name, age)
{
    public string Department { get; } = department;
    
    public new void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}, Age: {Age}, Department: {Department}");
    }
}

// Struct with primary constructor
public readonly struct Point(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
    
    public override string ToString() => $"({X}, {Y})";
}
