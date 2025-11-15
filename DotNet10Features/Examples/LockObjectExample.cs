namespace DotNet10Features.Examples;

/// <summary>
/// Demonstrates Lock Object improvements in .NET 10
/// New System.Threading.Lock type provides better performance and cleaner syntax
/// </summary>
public static class LockObjectExample
{
    public static void Run()
    {
        Console.WriteLine("\n=== Lock Object Example ===");
        
        var counter = new ThreadSafeCounter();
        
        // Create multiple threads to increment counter
        var threads = new List<Thread>();
        
        for (int i = 0; i < 5; i++)
        {
            int threadNum = i + 1;
            var thread = new Thread(() =>
            {
                for (int j = 0; j < 100; j++)
                {
                    counter.Increment();
                }
                Console.WriteLine($"Thread {threadNum} completed");
            });
            threads.Add(thread);
            thread.Start();
        }
        
        // Wait for all threads to complete
        foreach (var thread in threads)
        {
            thread.Join();
        }
        
        Console.WriteLine($"Final counter value: {counter.Value} (expected: 500)");
        
        // Demonstrate using statement with Lock
        var resource = new SharedResource();
        resource.UseResource("User 1");
        resource.UseResource("User 2");
    }
}

public class ThreadSafeCounter
{
    private readonly Lock _lock = new();
    private int _value = 0;
    
    public int Value => _value;
    
    public void Increment()
    {
        // New Lock type usage
        lock (_lock)
        {
            _value++;
        }
    }
}

public class SharedResource
{
    private readonly Lock _lock = new();
    
    public void UseResource(string user)
    {
        // Using lock with the new Lock type
        lock (_lock)
        {
            Console.WriteLine($"{user} accessing resource...");
            Thread.Sleep(10); // Simulate some work
            Console.WriteLine($"{user} finished with resource");
        }
    }
}
