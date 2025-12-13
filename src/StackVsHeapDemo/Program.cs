using BenchmarkDotNet.Running;

public class HumanClass
{
    public int Id  { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
}

public struct HumanStruct
{
    public int Id;
    public string? Name;
    public DateTime BirthDate;
}

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StackHeapBenchmark>();
    }
}