using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using Demo;

var config = ManualConfig.Create(DefaultConfig.Instance)
    .AddDiagnoser(MemoryDiagnoser.Default)
    .AddHardwareCounters()
    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
    .AddColumnProvider(DefaultColumnProviders.Metrics)
    .AddColumnProvider(DefaultColumnProviders.Statistics)
    .AddColumn(CategoriesColumn.Default)
    .AddColumn(RankColumn.Roman)
    .AddExporter(JsonExporter.Full);

BenchmarkRunner.Run(typeof(Program).Assembly, config);

public class Benchmark
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
