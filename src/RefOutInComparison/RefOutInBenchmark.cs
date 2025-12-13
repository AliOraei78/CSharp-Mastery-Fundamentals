using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class RefOutInBenchmark
{
    private const int Operations = 10_000_000;

    private BigStruct _data = new BigStruct
    {
        Field01 = 1,
        Field02 = 2,
        Field03 = 3,
        Field04 = 4,
        Field05 = 5,
        Field06 = 6,
        Field07 = 7,
        Field08 = 8,
        Field09 = 9,
        Field10 = 10,
        Field11 = 11,
        Field12 = 12,
        Field13 = 13,
        Field14 = 14,
        Field15 = 15,
        Field16 = 16,
        Field17 = 17,
        Field18 = 18,
        Field19 = 19,
        Field20 = 20,
        Field21 = 21,
        Field22 = 22,
        Field23 = 23,
        Field24 = 24,
        Field25 = 25,
        Field26 = 26,
        Field27 = 27,
        Field28 = 28,
        Field29 = 29,
        Field30 = 30,
        Field31 = 31,
        Field32 = 32,
        Field33 = 33,
        Field34 = 34,
        Field35 = 35,
        Field36 = 36,
        Field37 = 37,
        Field38 = 38,
        Field39 = 39,
        Field40 = 40,
        Field41 = 41,
        Field42 = 42,
        Field43 = 43,
        Field44 = 44,
        Field45 = 45,
        Field46 = 46,
        Field47 = 47,
        Field48 = 48,
        Field49 = 49,
        Field50 = 50,
        Field51 = 51,
        Field52 = 52,
        Field53 = 53,
        Field54 = 54,
        Field55 = 55,
        Field56 = 56,
        Field57 = 57,
        Field58 = 58,
        Field59 = 59,
        Field60 = 60,
        Field61 = 61,
        Field62 = 62,
        Field63 = 63,
        Field64 = 64
    };

    [Benchmark(Baseline = true)]
    public long ProcessNormal()
    {
        long sum = 0;
        for (int i = 0; i < Operations; i++)
            sum += CalculateNormal(_data);

        return sum;
    }

    [Benchmark]
    public long ProcessWithIn()
    {
        long sum = 0;
        for (int i = 0; i < Operations; i++)
            sum += CalculateWithIn(in _data);

        return sum;
    }

    [Benchmark]
    public long ProcessWithRef()
    {
        long sum = 0;
        for (int i = 0; i < Operations; i++)
            sum += CalculateWithRef(ref _data);

        return sum;
    }

    [Benchmark]
    public long ProcessWithOut()
    {
        long sum = 0;
        var temp = _data;
        for (int i = 0; i < Operations; i++)
            sum += CalculateWithOut(out temp);

        return sum;
    }

    private static long CalculateNormal(BigStruct data)
    {
        return data.Field01 + data.Field02 + data.Field03 + data.Field04 +
               data.Field05 + data.Field06 + data.Field07 + data.Field08 +
               data.Field09 + data.Field10 + data.Field11 + data.Field12 +
               data.Field13 + data.Field14 + data.Field15 + data.Field16 +
               data.Field17 + data.Field18 + data.Field19 + data.Field20 +
               data.Field21 + data.Field22 + data.Field23 + data.Field24 +
               data.Field25 + data.Field26 + data.Field27 + data.Field28 +
               data.Field29 + data.Field30 + data.Field31 + data.Field32 +
               data.Field33 + data.Field34 + data.Field35 + data.Field36 +
               data.Field37 + data.Field38 + data.Field39 + data.Field40 +
               data.Field41 + data.Field42 + data.Field43 + data.Field44 +
               data.Field45 + data.Field46 + data.Field47 + data.Field48 +
               data.Field49 + data.Field50 + data.Field51 + data.Field52 +
               data.Field53 + data.Field54 + data.Field55 + data.Field56 +
               data.Field57 + data.Field58 + data.Field59 + data.Field60 +
               data.Field61 + data.Field62 + data.Field63 + data.Field64;
    }
    private static long CalculateWithIn(in BigStruct data)
    {
        return data.Field01 + data.Field02 + data.Field03 + data.Field04 +
               data.Field05 + data.Field06 + data.Field07 + data.Field08 +
               data.Field09 + data.Field10 + data.Field11 + data.Field12 +
               data.Field13 + data.Field14 + data.Field15 + data.Field16 +
               data.Field17 + data.Field18 + data.Field19 + data.Field20 +
               data.Field21 + data.Field22 + data.Field23 + data.Field24 +
               data.Field25 + data.Field26 + data.Field27 + data.Field28 +
               data.Field29 + data.Field30 + data.Field31 + data.Field32 +
               data.Field33 + data.Field34 + data.Field35 + data.Field36 +
               data.Field37 + data.Field38 + data.Field39 + data.Field40 +
               data.Field41 + data.Field42 + data.Field43 + data.Field44 +
               data.Field45 + data.Field46 + data.Field47 + data.Field48 +
               data.Field49 + data.Field50 + data.Field51 + data.Field52 +
               data.Field53 + data.Field54 + data.Field55 + data.Field56 +
               data.Field57 + data.Field58 + data.Field59 + data.Field60 +
               data.Field61 + data.Field62 + data.Field63 + data.Field64;
    }
    private static long CalculateWithRef(ref BigStruct data)
    {
        return data.Field01 + data.Field02 + data.Field03 + data.Field04 +
               data.Field05 + data.Field06 + data.Field07 + data.Field08 +
               data.Field09 + data.Field10 + data.Field11 + data.Field12 +
               data.Field13 + data.Field14 + data.Field15 + data.Field16 +
               data.Field17 + data.Field18 + data.Field19 + data.Field20 +
               data.Field21 + data.Field22 + data.Field23 + data.Field24 +
               data.Field25 + data.Field26 + data.Field27 + data.Field28 +
               data.Field29 + data.Field30 + data.Field31 + data.Field32 +
               data.Field33 + data.Field34 + data.Field35 + data.Field36 +
               data.Field37 + data.Field38 + data.Field39 + data.Field40 +
               data.Field41 + data.Field42 + data.Field43 + data.Field44 +
               data.Field45 + data.Field46 + data.Field47 + data.Field48 +
               data.Field49 + data.Field50 + data.Field51 + data.Field52 +
               data.Field53 + data.Field54 + data.Field55 + data.Field56 +
               data.Field57 + data.Field58 + data.Field59 + data.Field60 +
               data.Field61 + data.Field62 + data.Field63 + data.Field64;
    }
    private static long CalculateWithOut(out BigStruct data)
    {
        data = new BigStruct();
        return data.Field01 + data.Field02;
    }
}