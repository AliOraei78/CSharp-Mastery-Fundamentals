using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class StackallocBenchmark
{
    private const int Operations = 100_000;

    [Benchmark]
    public long SumArrayList()
    {
        int[] arrayList = new int[Operations];
        for (int i = 0; i < Operations; i++)
            arrayList[i] = i;

        int sum = 0;

        for (int i = 0; i < Operations; i++)
            sum += arrayList[i];
        return sum;
    }

    [Benchmark]
    public long SumStackAlloc()
    {
        Span<int> stackAlloc = stackalloc int[Operations];
        for (int i = 0; i < Operations; i++)
            stackAlloc[i] = i;

        int sum = 0;

        for (int i = 0; i < Operations; i++)
            sum += stackAlloc[i];
        return sum;
    }
}