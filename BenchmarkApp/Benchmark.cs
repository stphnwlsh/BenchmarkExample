namespace BenchmarkApp;

using BenchmarkDotNet.Attributes;
using Generators;

[MemoryDiagnoser]
public class Benchmark
{
    [Params(100)]
    public int Iterations;

    [Benchmark]
    public void Locked()
    {
        this.Execution(new LockedRandom());
    }

    [Benchmark]
    public void Shared()
    {
        this.Execution(new SharedRandom());
    }

    [Benchmark]
    public void Thread()
    {
        this.Execution(new ThreadRandom());
    }

    private void Execution(IRandom random)
    {
        var array = new long[this.Iterations];

        ArgumentNullException.ThrowIfNull(array);

        for (var x = 0; x < this.Iterations; x++)
        {
            array[x] = random.Generate();
        }
    }
}
