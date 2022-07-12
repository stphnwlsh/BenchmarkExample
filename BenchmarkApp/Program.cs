using BenchmarkApp;
using BenchmarkDotNet.Running;

Console.WriteLine("Started Running");

_ = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine("Finished Running");
