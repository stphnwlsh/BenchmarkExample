namespace BenchmarkApp;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Benchmark
{
    [Params(1000, 100000, 10000000)]
    public int Iterations;

    [Benchmark]
    public void RandomNext()
    {
        var list = new List<long>();

        ArgumentNullException.ThrowIfNull(list);

        var random = new Random();

        for (var x = 0; x < this.Iterations; x++)
        {
            list.Add(random.Next(int.MinValue, int.MaxValue));
        }
    }

    [Benchmark]
    public void RandomNextMultiple()
    {
        var list = new List<long>();

        ArgumentNullException.ThrowIfNull(list);

        for (var x = 0; x < this.Iterations; x++)
        {
            var random = new Random();
            list.Add(random.Next(int.MinValue, int.MaxValue));
        }
    }

    [Benchmark]
    public void RandomSharedNext()
    {
        var list = new List<long>();

        ArgumentNullException.ThrowIfNull(list);

        for (var x = 0; x < this.Iterations; x++)
        {
            list.Add(Random.Shared.Next(int.MinValue, int.MaxValue));
        }
    }
}
