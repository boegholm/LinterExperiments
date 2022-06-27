using System.Security.Cryptography;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using LinterExperiments.Smells.CodeSmellExamples;

namespace LinterExperiments.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<LinterExperiments>();
        }
    }
    [RPlotExporter]
    public class LinterExperiments
    {
        private DeadLocalStoreBase bad = new DeadLocalStoreBad();
        private DeadLocalStoreBase good = new DeadLocalStoreGood();
        //private SHA256 sha256 = SHA256.Create();
        //private MD5 md5 = MD5.Create();
        //private byte[] data;

        //[Params(1000, 10000)]
        //public int N;

        //[GlobalSetup]
        //public void Setup()
        //{
        //    data = new byte[N];
        //    new Random(42).NextBytes(data);
        //}
        int n = 5_000_000;
        [Benchmark]
        public void Good()
        {
            for(int i=0;i<n;i++)
                good.DeadLocalStore(0.4250);
        }

        [Benchmark]
        public void Bad()
        {
            for (int i = 0; i < n; i++)
                bad.DeadLocalStore(0.4250);
        }
    }
}