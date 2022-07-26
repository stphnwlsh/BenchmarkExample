using Generators;

Console.WriteLine("Started Running");

const int iterations = 10000000;

var array = new long[iterations];

var failed = new FailedRandom();
var shared = new SharedRandom();
var locked = new LockedRandom();
var thread = new ThreadRandom();

_ = Parallel.For(0, iterations, (x, loop) =>
{
    // Generate Random Number
    var number = shared.Next();

    // Add Random Number to Array
    array[x] = number;

    // Check if the Random Number Failed to Generate Properly
    if (number == 0)
    {
        Console.WriteLine($"{x}: FAILED");
        loop.Stop();
    }
});

Console.WriteLine($"List has {array.Length} items");

Console.WriteLine("Finished Running");
