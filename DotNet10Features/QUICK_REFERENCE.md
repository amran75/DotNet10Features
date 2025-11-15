# .NET 10 Features Quick Reference Guide

## 1. Collection Expressions

**Syntax:** Use `[]` to create collections

```csharp
// Array
int[] numbers = [1, 2, 3, 4, 5];

// List
List<string> fruits = ["Apple", "Banana", "Orange"];

// Spread operator (..)
int[] combined = [..array1, ..array2];

// Mixed
List<int> mixed = [1, ..existing, 5];

// Empty
int[] empty = [];
```

**Benefits:**
- Cleaner, more concise syntax
- Works with arrays, lists, spans, and more
- Spread operator for easy combination

---

## 2. Primary Constructors

**Syntax:** Declare constructor parameters in the class/struct declaration

```csharp
// Class with primary constructor
public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;
}

// Usage
var person = new Person("John", 30);

// Inheritance
public class Employee(string name, int age, string dept) : Person(name, age)
{
    public string Department { get; } = dept;
}
```

**Benefits:**
- Less boilerplate code
- Parameters available throughout the class
- Cleaner inheritance syntax

---

## 3. Default Lambda Parameters

**Syntax:** Lambda expressions can have default parameter values

```csharp
// Simple lambda with default
var greet = (string name = "Guest") => $"Hello, {name}!";

greet();           // "Hello, Guest!"
greet("Alice");    // "Hello, Alice!"

// Multiple defaults
var calc = (decimal price, decimal tax = 0.10m, decimal discount = 0m) =>
    price + (price * tax) - discount;
```

**Benefits:**
- More flexible lambda expressions
- Reduces overload necessity
- Cleaner API design

---

## 4. Params Collections

**Syntax:** Use params with any collection type

```csharp
// Traditional params array
public void Process(params int[] numbers) { }

// Params with List
public void Process(params List<int> numbers) { }

// Params with ReadOnlySpan (best performance)
public void Process(params ReadOnlySpan<int> numbers) { }

// Usage
Process(1, 2, 3, 4, 5);
```

**Benefits:**
- Better performance options
- More flexible API design
- Backward compatible

---

## 5. Lock Object Improvements

**Syntax:** Use new `System.Threading.Lock` type

```csharp
public class Counter
{
    private readonly Lock _lock = new();
    private int _value = 0;
    
    public void Increment()
    {
        lock (_lock)
        {
            _value++;
        }
    }
}
```

**Benefits:**
- Better performance
- Cleaner semantics
- Designed for modern async/await patterns

---

## 6. Inline Arrays

**Syntax:** Stack-allocated fixed-size arrays

```csharp
// Define inline array struct
[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer10<T>
{
    private T _element0;
}

// Usage
var buffer = new Buffer10<int>();
buffer[0] = 100;
buffer[1] = 200;

// Works with Span
Span<int> span = buffer;
```

**Benefits:**
- Stack allocation (no heap)
- Better performance
- Fixed-size guarantees

---

## 7. Alias Any Type

**Syntax:** Create aliases for any type including tuples and arrays

```csharp
// At file level
using Point2D = (double X, double Y);
using StringArray = string[];
using IntMatrix = int[][];
using PersonList = List<(string Name, int Age)>;

// Usage
Point2D point = (10.5, 20.3);
StringArray names = ["Alice", "Bob"];
```

**Benefits:**
- Improved code readability
- Better type reusability
- Simplified complex type declarations

---

## 8. Ref Readonly Parameters

**Syntax:** Pass by reference without allowing modifications

```csharp
public void Process(ref readonly LargeStruct data)
{
    // Can read data without copying
    Console.WriteLine(data.Value);
    
    // Cannot modify
    // data.Value = 10; // Compiler error
}

// Usage
var largeData = new LargeStruct { Value = 100 };
Process(in largeData);
```

**Benefits:**
- No copy overhead for large structs
- Prevents accidental modifications
- Better performance

---

## Migration Tips

### From older .NET versions:

1. **Collections:** Replace `new[] { 1, 2, 3 }` with `[1, 2, 3]`
2. **Constructors:** Consider primary constructors for simple classes
3. **Locks:** Replace `object` lock with `System.Threading.Lock`
4. **Type aliases:** Use file-scoped aliases for commonly used types

### Performance Considerations:

- Use `ReadOnlySpan<T>` with params for performance-critical code
- Use inline arrays for small, fixed-size buffers
- Use ref readonly for large struct parameters
- Collection expressions are optimized by the compiler

---

## Common Patterns

### Builder Pattern with Primary Constructor
```csharp
public class RequestBuilder(string url)
{
    private readonly Dictionary<string, string> _headers = [];
    
    public RequestBuilder AddHeader(string key, string value)
    {
        _headers[key] = value;
        return this;
    }
}
```

### High-Performance Buffer Processing
```csharp
[InlineArray(1024)]
public struct Buffer1K<T>
{
    private T _element0;
}

public void ProcessData(params ReadOnlySpan<byte> data)
{
    var buffer = new Buffer1K<byte>();
    // Process data with minimal allocations
}
```

### Thread-Safe Operations
```csharp
public class Cache<TKey, TValue>
{
    private readonly Lock _lock = new();
    private readonly Dictionary<TKey, TValue> _data = [];
    
    public void Add(TKey key, TValue value)
    {
        lock (_lock)
        {
            _data[key] = value;
        }
    }
}
```

---

## Resources

- [.NET 10 Release Notes](https://docs.microsoft.com/dotnet/core/whats-new/dotnet-10)
- [C# 12 Language Features](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-12)
- [.NET Blog](https://devblogs.microsoft.com/dotnet/)
- [C# Language Design](https://github.com/dotnet/csharplang)
