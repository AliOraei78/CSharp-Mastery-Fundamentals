using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class SpanAndRefStructBenchmark
{
    private const int Operations = 100_000_000;

    [Benchmark]
    public long SumWithArray()
    {
        byte[] data = new byte[Operations];
        for (int i = 0; i < data.Length; i++)
            data[i] = (byte)(i % 256);

        long sum = 0;
        for(int i = 0; i < data.Length; i++)
            sum += data[i];
        return sum;
    }

    [Benchmark]
    public long SumWithSpan()
    {
        byte[] data = new byte[Operations];
        for (int i = 0; i < data.Length; i++)
            data[i] = (byte)(i % 256);

        Span<byte> span = data; 

        long sum = 0;
        for (int i = 0; i < span.Length; i++)
            sum += span[i];
        return sum;
    }
}