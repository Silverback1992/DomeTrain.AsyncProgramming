namespace UsingAsync;

public abstract class Food
{
    readonly TimeSpan _cookTime;

    protected Food(TimeSpan cookTime)
    {
        _cookTime = cookTime;
        Name = GetType().Name;
    }

    public string Name { get; }

    public async Task Cook()
    {
        Console.WriteLine($"Cooking {Name}");
        Console.WriteLine($"Thread Id: {Environment.CurrentManagedThreadId}");
        await Task.Delay(_cookTime);
        Console.WriteLine($"{Name} Completed");
        Console.WriteLine($"Thread Id: {Environment.CurrentManagedThreadId}");
    }
}

public class Turkey() : Food(TimeSpan.FromSeconds(5));
public class MashedPotatoes() : Food(TimeSpan.FromSeconds(2));
public class Gravy() : Food(TimeSpan.FromSeconds(1));
public class Stuffing() : Food(TimeSpan.FromSeconds(2));