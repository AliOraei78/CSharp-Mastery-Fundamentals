using BenchmarkDotNet.Running;


public struct BigStruct
{
    public int Field01; public int Field02; public int Field03; public int Field04; public int Field05;
    public int Field06; public int Field07; public int Field08; public int Field09; public int Field10;
    public int Field11; public int Field12; public int Field13; public int Field14; public int Field15;
    public int Field16; public int Field17; public int Field18; public int Field19; public int Field20;
    public int Field21; public int Field22; public int Field23; public int Field24; public int Field25;
    public int Field26; public int Field27; public int Field28; public int Field29; public int Field30;
    public int Field31; public int Field32; public int Field33; public int Field34; public int Field35;
    public int Field36; public int Field37; public int Field38; public int Field39; public int Field40;
    public int Field41; public int Field42; public int Field43; public int Field44; public int Field45;
    public int Field46; public int Field47; public int Field48; public int Field49; public int Field50;
    public int Field51; public int Field52; public int Field53; public int Field54; public int Field55;
    public int Field56; public int Field57; public int Field58; public int Field59; public int Field60;
    public int Field61; public int Field62; public int Field63; public int Field64;
}
public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<RefOutInBenchmark>();
    }
}