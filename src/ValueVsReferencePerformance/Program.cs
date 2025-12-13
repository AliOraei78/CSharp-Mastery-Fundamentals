using BenchmarkDotNet.Running;

public class CustomerClass
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Balance { get; set; }
    public DateTime RegistrationDate { get; set; }
    public bool IsActive { get; set; }
}

public struct CustomerStruct
{
    public int Id;
    public string? Name;
    public decimal Balance;
    public DateTime RegistrationDate;
    public bool IsActive;
}

class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<ValueVsReferenceBenchmark>();
    }
}