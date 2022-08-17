using Generators;

Console.WriteLine("Started Running");

const int iterations = 10000000;

var array = new long[iterations];

var failed = new FailedRandom();
var shared = new SharedRandom();
var locked = new LockedRandom();
var thread = new ThreadRandom();

var generators = new List<IRandom> { failed, shared, locked, thread };

foreach (var generator in generators)
{
    Console.WriteLine($"Started Running - {generator.Name}");

    var failures = 0;

    _ = Parallel.For(0, iterations, (x, loop) =>
    {
        // Generate Random Number
        var number = generator.Generate();

        // Add Random Number to Array
        array[x] = number;

        // Check if the Random Number Failed to Generate Properly
        if (number == 0)
        {
            Console.WriteLine($"GENERATOR FAILED on iteration {x}");
            failures++;
            loop.Stop();
        }
    });

    Console.WriteLine($"{generator.Name} generated {array.Length - failures} unique items");

    Console.WriteLine($"Finished Running - {generator.Name}");
}

Console.WriteLine("Finished Running");
