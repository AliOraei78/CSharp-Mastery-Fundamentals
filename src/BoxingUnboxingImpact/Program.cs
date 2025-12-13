using BenchmarkDotNet.Running;

class Pogram
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BoxingBenchmark>();
    }
}