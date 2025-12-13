using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class AsyncMemorySpanBenchmark
{
    [Benchmark]
    public async Task<long> ProcessWithMemory()
    {
        byte[] data = new byte[100_000_000];
        Memory<byte> memory = data;
        long sum = 0;
        await Task.Run(() =>
        {
            for (int i = 0; i < memory.Length; i++) 
                sum += memory.Span[i];
        });
        return sum;
    }

    [Benchmark]
    public async Task ProcessWithSpan()
    {
        byte[] data = new byte[100_000_000];
        Span<byte> span = data;
        await Task.Delay(1);

        span[0] = 1;
    }
}