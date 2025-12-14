using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class GarbageCollectorBenchmark
{
    private List<object> _longLived = new List<object>();
    private const int _operations = 1_000_000;
    [Benchmark]
    public void CreateSmallObejects()
    {
        for (int i = 0; i < _operations; i++)
        {
            string str = new string('a', 20);
            _ = str.GetHashCode();
        }
    }

    [Benchmark]
    public void CreateLargeObejects()
    {
        for (int i = 0; i < 1000; i++)
        {
            byte[] large = new byte[100_000];
            large[0] = 1;
        }
    }

    [Benchmark]
    public void CreateLongLivedObejects()
    {
        for (int i = 0; i < 100_000; i++)
        {
            var obj = new byte[100_000];
            obj[0] = (byte)i;
            _longLived.Add(obj);
        }
        GC.KeepAlive(_longLived);
    }
}