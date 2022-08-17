# BenchmarkExample

An example implementation of BenchmarkDotNet in C# running in .NET 6

## Run the Benchmarks

There are two options to run the benchmark tests, directly on your machine or in a container.

### Local

``` bash
dotnet run --project ./BenchmarkApp/BenchmarkApp.csproj -c Release
```

### Container

``` bash
docker build -t benchmark .
docker run benchmark
```
