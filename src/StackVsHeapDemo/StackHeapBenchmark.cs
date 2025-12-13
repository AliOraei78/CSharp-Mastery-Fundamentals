using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class StackHeapBenchmark
{
    private const int Operations = 10_000;

    [Benchmark]
    public void CreateObjects()
    {
        List<HumanClass> objects = new List<HumanClass>(Operations);
        for (int i = 0; i < Operations; i++)
        { 
            objects.Add(new HumanClass()
            {
                Id = i,
                Name = $"User{i}",
                BirthDate = DateTime.Now
            });
        }
        GC.KeepAlive(objects);
    }

    [Benchmark]
    public void CreateLocalStructs()
    {
        for (int i = 0; i < Operations; i++)
        {
            HumanStruct s = new HumanStruct()
            {
                Id = i,
                Name = $"User{i}",
                BirthDate = DateTime.Now
            };
            GC.KeepAlive(s);
        }
    }
}