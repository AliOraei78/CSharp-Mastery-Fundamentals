using BenchmarkDotNet.Running;

public class CustomerClass
{
    public int Id { get; set; }
    public int Age { get; set; }
    public int Score { get; set; }
}

public struct CustomerStruct
{
    public int Id;
    public int Age;
    public int Score;
}

class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StructClassBestUseBenchmark>();
    }
}