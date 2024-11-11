using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Claunia.PropertyList.Benchmark
{
    [SimpleJob(RuntimeMoniker.Net90), MemoryDiagnoser]
    public class BinaryPropertyListWriterBenchmarks
    {
        NSObject data;

        [GlobalSetup]
        public void Setup() => data = PropertyListParser.Parse("plist.bin");

        [Benchmark]
        public byte[] WriteLargePropertylistTest() => BinaryPropertyListWriter.WriteToArray(data);
    }
}