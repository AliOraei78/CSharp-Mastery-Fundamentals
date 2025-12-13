using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class StructClassBestUseBenchmark
{
    private const int Operations = 1_000_000;

    [Benchmark]
    public void CreateClass()
    {
        var customerClasses = new List<CustomerClass>(Operations);
        int sum = 0;
        for (int i = 0; i < Operations; i++)
        {
            customerClasses.Add(new CustomerClass()
            {
                Id = i,
                Age = 1000 + i,
                Score = i * 100
            });
        }
        for (int i = 0; i < Operations; i++)
            sum+= customerClasses[i].Score;
        GC.KeepAlive(customerClasses);
    }

    [Benchmark]
    public void CreateStruct()
    {
        var customerStruct = new List<CustomerStruct>(Operations);
        int sum = 0;
        for (int i = 0; i < Operations; i++)
        {
            customerStruct.Add(new CustomerStruct()
            {
                Id = i,
                Age = 1000 + i,
                Score = i * 100
            });
        }
        for (int i = 0; i < Operations; i++)
            sum += customerStruct[i].Score;
        GC.KeepAlive(customerStruct);
    }
}