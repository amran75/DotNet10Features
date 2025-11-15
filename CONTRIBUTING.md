# Contributing to .NET 10 Features

Thank you for your interest in contributing to this project! This repository is designed to help developers learn .NET 10 features together.

## How to Contribute

### Adding New Feature Examples

1. **Create a new example file** in the `DotNet10Features/Examples/` directory
2. **Follow the naming convention**: `FeatureNameExample.cs`
3. **Use the template structure**:

```csharp
namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates [Feature Name] in C# 12/.NET 10
/// Brief description of the feature
/// </summary>
public static class FeatureNameExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Feature Name Example ===");
        
        // Your example code here
        
        // Show multiple use cases
        // Include comments explaining what's happening
    }
}
```

4. **Add your example to Program.cs**:

```csharp
// In Program.cs, add after existing examples:
FeatureNameExample.Run();
```

5. **Test your example**:
```bash
dotnet build
dotnet run
```

### Improving Existing Examples

- Make examples clearer and more educational
- Add more use cases
- Improve comments and documentation
- Fix any bugs or issues

### Documentation

- Update README.md if adding major features
- Update QUICK_REFERENCE.md with syntax and usage
- Ensure code comments are clear and helpful

## Code Style Guidelines

1. **Use clear, descriptive names** for variables and methods
2. **Add XML documentation** for public classes and methods
3. **Include comments** explaining non-obvious code
4. **Follow C# naming conventions**:
   - PascalCase for classes, methods, properties
   - camelCase for local variables and parameters
   - _camelCase for private fields
5. **Keep examples simple** and focused on the feature
6. **Avoid external dependencies** when possible

## Example Criteria

Good examples should:
- ✅ Demonstrate a single feature clearly
- ✅ Show practical, real-world use cases
- ✅ Include multiple scenarios
- ✅ Have clear output that shows the feature working
- ✅ Be self-contained and runnable
- ✅ Include helpful comments

Avoid:
- ❌ Complex scenarios that obscure the feature
- ❌ Mixing multiple unrelated features
- ❌ Production-level code (keep it educational)
- ❌ External dependencies unless necessary

## Testing

Before submitting:
1. Build the project: `dotnet build`
2. Run the application: `dotnet run`
3. Verify your example runs without errors
4. Check that output is clear and helpful

## Submitting Changes

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-feature-name`
3. Make your changes
4. Test thoroughly
5. Commit with clear messages: `git commit -m "Add example for [feature]"`
6. Push to your fork: `git push origin feature/your-feature-name`
7. Create a Pull Request

## Pull Request Guidelines

Your PR should:
- Have a clear title describing the change
- Include a description of what was added/changed
- Reference any related issues
- Pass all builds and tests
- Follow the code style guidelines

## Questions or Issues?

- Open an issue for bugs or feature requests
- Use discussions for questions or ideas
- Keep issues focused and provide details

## Code of Conduct

- Be respectful and constructive
- Focus on learning and helping others learn
- Keep examples educational and accessible
- Welcome newcomers and help them contribute

## License

By contributing, you agree that your contributions will be available under the same license as the project.

---

Thank you for helping make this a great learning resource! 🎓
