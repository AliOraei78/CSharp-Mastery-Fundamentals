using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Tracing.Parsers.JScript;

[MemoryDiagnoser]
public class ValueVsReferenceBenchmark
{
    private const int Operations = 10_000_000;
    private CustomerClass _classInstance = new() { Id = 1, Name = "Test", Balance = 1000m, RegistrationDate = DateTime.UtcNow, IsActive = true };
    private CustomerStruct _structInstance = new() { Id = 1, Name = "Test", Balance = 1000m, RegistrationDate = DateTime.UtcNow, IsActive = true };

    [Benchmark]
    public void CopyClass()
    {
        CustomerClass copy = null;
        for (int i = 0; i < Operations; i++)
        {
            copy = _classInstance;
        }
        GC.KeepAlive(copy);
    }
    
    [Benchmark]
    public void CopyStruct()
    {
        CustomerStruct copy = default;
        for (int i = 0; i < Operations; i++)
        {
            copy = _structInstance;
        }
        GC.KeepAlive(copy);
    }

    [Benchmark]
    public void AllocateListClass()
    {
        var list = new List<CustomerClass>(1_000_000);
        for (int i = 0;i < 1_000_000; i++)
        {
            list.Add(new CustomerClass { Id = i });
        }
        GC.KeepAlive(list);
    }

    [Benchmark]
    public void AllocateListStruct()
    {
        var list = new List<CustomerStruct>(1_000_000);
        for (int i = 0; i < 1_000_000; i++)
        {
            list.Add(new CustomerStruct { Id = i });
        }
        GC.KeepAlive(list);
    }
}