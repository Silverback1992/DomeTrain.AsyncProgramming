using LifeBeforeAsync;

// Uncomment scenarios to see them work 1 by 1

#region Scenario 1

//Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} started to work.");

//Console.WriteLine("Cooking Started");

//var turkey = new Turkey();
//turkey.Cook();

//Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is working.");

#endregion

#region Scenario 2

//Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} started to work.");

//Console.WriteLine("Cooking Started");

//var turkey = new Turkey();
//turkey.Cook();

//Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is working.");

//Console.ReadLine();

#endregion

#region Scenario 3

Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} started to work.");

Console.WriteLine("Cooking Started");

var turkey = new Turkey();
turkey.Cook()
    .ContinueWith(_ =>
    {
        var gravy = new Gravy();
        gravy.Cook();
    });


Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} is working.");

Console.ReadLine();

#endregion