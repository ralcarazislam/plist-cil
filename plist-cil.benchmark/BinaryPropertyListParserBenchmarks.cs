using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Claunia.PropertyList.Benchmark
{
    [SimpleJob(RuntimeMoniker.Net90), MemoryDiagnoser]
    public class BinaryPropertyListParserBenchmarks
    {
        private byte[] _data = [];

        [GlobalSetup]
        public void Setup() => _data = File.ReadAllBytes("plist.bin");

        [Benchmark]
        public NSObject ReadLargePropertyListTest()
        {
            NSObject nsObject = PropertyListParser.Parse(_data);

            return nsObject;
        }
    }
}