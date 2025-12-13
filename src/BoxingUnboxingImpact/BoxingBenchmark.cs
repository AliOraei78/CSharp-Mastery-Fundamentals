using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections;
using System.Collections.Generic;

[MemoryDiagnoser]
public class BoxingBenchmark
{
    private const int Operations = 10_000_000;
    [Benchmark]
    public void TestList()
    {
        List<int> list = new List<int>(Operations);
        int sum = 0;
        for (int i = 0; i < Operations; i++)
        {
            list.Add(i);
            sum += i;
        }
        GC.KeepAlive(list);
    }

    [Benchmark]
    public void TestArrayList()
    {
        ArrayList arrayList = new ArrayList(Operations);
        int sum = 0;
        for (int i = 0; i < Operations; i++)
        {
            arrayList.Add(i);
            sum += i;
        }
        GC.KeepAlive(arrayList);
    }
}