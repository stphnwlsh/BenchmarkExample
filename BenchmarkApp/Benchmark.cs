namespace BenchmarkApp;

using BenchmarkDotNet.Attributes;
using Generators;

[MemoryDiagnoser]
public class Benchmark
{
    [Params(1000, 100000, 100000000)]
    public int Iterations;

    [Benchmark]
    public void Locked()
    {
        var array = new long[this.Iterations];

        ArgumentNullException.ThrowIfNull(array);

        var random = new LockedRandom();

        for (var x = 0; x < this.Iterations; x++)
        {
            array[x] = random.Next();
        }
    }

    [Benchmark]
    public void Shared()
    {
        var array = new long[this.Iterations];

        ArgumentNullException.ThrowIfNull(array);

        var random = new SharedRandom();

        for (var x = 0; x < this.Iterations; x++)
        {
            array[x] = random.Next();
        }
    }

    [Benchmark]
    public void Thread()
    {
        var array = new long[this.Iterations];

        ArgumentNullException.ThrowIfNull(array);

        var random = new ThreadRandom();

        for (var x = 0; x < this.Iterations; x++)
        {
            array[x] = random.Next();
        }
    }

    [Benchmark]
    public void ParallelLocked()
    {
        var array = new long[this.Iterations];

        ArgumentNullException.ThrowIfNull(array);

        var random = new LockedRandom();

        _ = Parallel.For(0, this.Iterations, x =>
        {
            array[x] = random.Next();
        });
    }

    [Benchmark]
    public void ParallelShared()
    {
        var array = new long[this.Iterations];

        ArgumentNullException.ThrowIfNull(array);

        var random = new SharedRandom();

        _ = Parallel.For(0, this.Iterations, x =>
        {
            array[x] = random.Next();
        });
    }

    [Benchmark]
    public void ParallelThread()
    {
        var array = new long[this.Iterations];

        ArgumentNullException.ThrowIfNull(array);

        var random = new ThreadRandom();

        _ = Parallel.For(0, this.Iterations, x =>
        {
            array[x] = random.Next();
        });
    }
}
