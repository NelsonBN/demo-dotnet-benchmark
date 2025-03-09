using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using Xunit;
using Xunit.Abstractions;

namespace Demo.Benchmarks.Tests;

public class BenchmarksTests(ITestOutputHelper output)
{
    private readonly ITestOutputHelper _output = output;

    [Fact]
    public void RunBenchmarks()
    {
        var logger = new AccumulationLogger();

        var config = ManualConfig.Create(DefaultConfig.Instance)
            .AddLogger(logger)
            .WithOptions(ConfigOptions.DisableOptimizationsValidator);

        BenchmarkRunner.Run<BenchmarkMethos>(config);

        _output.WriteLine(logger.GetLog());
    }


    public class BenchmarkMethos
    {
        [Benchmark(Baseline = true)]
        public void StringJoin()
        {
            var value = Helper.StringJoin("hello", "world");
        }

        [Benchmark]
        public void StringConcat()
        {
            var value = Helper.StringConcat("hello", "world");
        }
    }

}
