using DotNet10Features.Examples;

Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
Console.WriteLine("║         Welcome to .NET 10 Features Demonstration           ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
Console.WriteLine();
Console.WriteLine("This application demonstrates key features introduced in");
Console.WriteLine("C# 12 and .NET 10 to help you learn them one by one.");
Console.WriteLine();

try
{
    // Feature 1: Collection Expressions
    CollectionExpressionsExample.Run();
    
    // Feature 2: Primary Constructors
    PrimaryConstructorsExample.Run();
    
    // Feature 3: Default Lambda Parameters
    DefaultLambdaParametersExample.Run();
    
    // Feature 4: Params Collections
    ParamsCollectionsExample.Run();
    
    // Feature 5: Lock Object Improvements
    LockObjectExample.Run();
    
    // Feature 6: Inline Arrays
    InlineArraysExample.Run();
    
    // Feature 7: Alias Any Type
    AliasAnyTypeExample.Run();
    
    // Feature 8: Ref Readonly Parameters
    RefReadonlyParametersExample.Run();
    
    Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
    Console.WriteLine("║              All Examples Completed Successfully!           ║");
    Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
}
catch (Exception ex)
{
    Console.WriteLine($"\n❌ Error: {ex.Message}");
    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
}
