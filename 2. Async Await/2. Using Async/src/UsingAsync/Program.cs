using UsingAsync;

Console.WriteLine("Cooking Started");

Console.WriteLine($"Thread Id: {Environment.CurrentManagedThreadId}");

var turkey = new Turkey();
await turkey.Cook();

Console.WriteLine($"Thread Id: {Environment.CurrentManagedThreadId}");

var gravy = new Gravy();
await gravy.Cook();

Console.WriteLine($"Thread Id: {Environment.CurrentManagedThreadId}");

Console.WriteLine("Ready to eat");
