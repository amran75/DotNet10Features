# .NET 10 Features Repository

Welcome! This repository contains comprehensive examples of .NET 10 and C# 12 features to help developers learn and understand the latest improvements in the .NET ecosystem.

## 🎯 Purpose

This repository demonstrates .NET 10 features one by one, making it easy to learn and understand each new capability through practical, runnable examples.

## 🚀 Features Covered

### 1. **Collection Expressions**
- Concise syntax for creating collections using `[]` syntax
- Spread operator `..` for combining collections
- Works with arrays, lists, spans, and more

### 2. **Primary Constructors**
- Define constructor parameters directly in class/struct declarations
- Cleaner, more concise code
- Parameters available throughout the class

### 3. **Default Lambda Parameters**
- Lambda expressions can now have default parameter values
- More flexible and expressive lambda syntax
- Reduces code duplication

### 4. **Params Collections**
- `params` keyword now works with any collection type
- Better performance with `ReadOnlySpan<T>`
- More flexible API design

### 5. **Lock Object Improvements**
- New `System.Threading.Lock` type for better thread synchronization
- Improved performance over traditional lock patterns
- Cleaner syntax for thread-safe operations

### 6. **Inline Arrays**
- Stack-allocated fixed-size arrays
- Better performance for small, fixed-size buffers
- Efficient memory usage

### 7. **Alias Any Type**
- Create type aliases for tuples, arrays, and complex types
- Improved code readability
- Better type reusability

### 8. **Ref Readonly Parameters**
- Pass large structs by reference without copying
- Prevents modifications to the parameter
- Better performance for large data structures

## 📋 Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) installed
- Any IDE or text editor (Visual Studio 2022, VS Code, Rider, etc.)

## 🏃 Running the Examples

### Clone the repository:
```bash
git clone https://github.com/amran75/DotNetFeatures.git
cd DotNetFeatures
```

### Build and run:
```bash
cd DotNet10Features
dotnet build
dotnet run
```

The application will run all examples sequentially, demonstrating each .NET 10 feature.

## 📁 Project Structure

```
DotNetFeatures/
├── DotNet10Features/
│   ├── Examples/
│   │   ├── CollectionExpressionsExample.cs
│   │   ├── PrimaryConstructorsExample.cs
│   │   ├── DefaultLambdaParametersExample.cs
│   │   ├── ParamsCollectionsExample.cs
│   │   ├── LockObjectExample.cs
│   │   ├── InlineArraysExample.cs
│   │   ├── AliasAnyTypeExample.cs
│   │   └── RefReadonlyParametersExample.cs
│   ├── Program.cs
│   └── DotNet10Features.csproj
└── README.md
```

## 🔍 Exploring Individual Features

Each example is self-contained in its own file under the `Examples/` directory. You can:

1. Review the code for each feature
2. Run the entire application to see all examples
3. Modify examples to experiment with the features

## 📚 Learning Resources

- [What's New in .NET 10](https://docs.microsoft.com/dotnet/core/whats-new/dotnet-10)
- [C# 12 Language Features](https://docs.microsoft.com/dotnet/csharp/whats-new/csharp-12)
- [.NET Blog](https://devblogs.microsoft.com/dotnet/)

## 🤝 Contributing

Feel free to contribute by:
- Adding more feature examples
- Improving existing examples
- Fixing issues
- Adding documentation

## 📝 License

This project is open source and available for educational purposes.

## ✨ Author

Created to help developers learn .NET 10 features together!

---

**Happy Learning! 🎓**