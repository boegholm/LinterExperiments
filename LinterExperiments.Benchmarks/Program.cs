using System.Security.Cryptography;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using LinterExperiments.Smells.CodeSmellExamples;

namespace LinterExperiments.Benchmarks
{
    [RPlotExporter]
    [BenchmarkDotNet.Attributes.AsciiDocExporter]
    public class AllLinterEx
    {
        [Benchmark] public void DeadCodeBad_Run() => new DeadCodeBad().Run();
        [Benchmark] public void DeadCodeGood_Run() => new DeadCodeGood().Run();
        [Benchmark] public double DeadLocalStoreBad_Run() => new DeadLocalStoreBad().Run();
        [Benchmark] public double DeadLocalStoreGood_Run() => new DeadLocalStoreGood().Run();
        [Benchmark] public void DuplicateCodeBad_SumElements() => new DuplicateCodeBad().SumElements();
        [Benchmark] public void DuplicateCodeGood_SumElements() => new DuplicateCodeGood().SumElements();
        [Benchmark] public string FeatureEnvyBad_GetFullAddress() => new FeatureEnvyBad(new ContactInfo()).GetFullAddress();
        [Benchmark] public string FeatureEnvyGood_GetFullAddress() => new FeatureEnvyGood().GetFullAddress();
        [Benchmark] public string GodClassBad_GetCandidateInfo() => new GodClassBad().GetCandidateInfo();
        [Benchmark] public string GodClassGood_GetCandidateInfo() => new GodClassGood().GetCandidateInfo();
        [Benchmark] public void InLineBad_InLine() => new InLineBad().InLine();
        [Benchmark] public void InLineGood_InLine() => new InLineGood().InLine();
        [Benchmark] public void LongMethodBad_Compute() => new LongMethodBad().Compute();
        [Benchmark] public void LongMethodGood_Compute() => new LongMethodGood().Compute();
        [Benchmark] public void ParameterByValueBad_ParameterByValue() => new ParameterByValueBad().ParameterByValue();
        [Benchmark] public void ParameterByValueGood_ParameterByValue() => new ParameterByValueGood().ParameterByValue();
        [Benchmark] public int[] RedundantDataStorageBad_ReverseList() => new RedundantDataStorageBad().ReverseList();
        [Benchmark] public int[] RedundantDataStorageBad_SortList() => new RedundantDataStorageBad().SortList();
        [Benchmark] public int RedundantDataStorageBad_SumList() => new RedundantDataStorageBad().SumList();
        [Benchmark] public int[] RedundantDataStorageGood_ReverseList() => new RedundantDataStorageGood().ReverseList();
        [Benchmark] public int[] RedundantDataStorageGood_SortList() => new RedundantDataStorageGood().SortList();
        [Benchmark] public int RedundantDataStorageGood_SumList() => new RedundantDataStorageGood().SumList();
        [Benchmark] public void RepeatedConditionalsBad_RepeatedConditionals() => new RepeatedConditionalsBad().RepeatedConditionals();
        [Benchmark] public void RepeatedConditionalsGood_RepeatedConditionals() => new RepeatedConditionalsGood().RepeatedConditionals();
        [Benchmark] public string SelfAssignmentBad_SelfAssignment() => new SelfAssignmentBad().SelfAssignment();
        [Benchmark] public string SelfAssignmentGood_SelfAssignment() => new SelfAssignmentGood().SelfAssignment();
        [Benchmark] public void ShortCircuitBad_ShortCircuit() => new ShortCircuitBad().ShortCircuit();
        [Benchmark] public void ShortCircuitGood_ShortCircuit() => new ShortCircuitGood().ShortCircuit();
        [Benchmark] public string TypeCheckingGood_getType() => new TypeCheckingGood().getType();
        [Benchmark] public string TypeCheckingRTTIBadGetClass_getType() => new TypeCheckingRTTIBadGetClass().getType();
        [Benchmark] public string TypeCheckingRTTIBadInstanceOf_getType() => new TypeCheckingRTTIBadInstanceOf().getType();
        [Benchmark] public string TypeCheckingTypeFieldBadIfElse_getType() => new TypeCheckingTypeFieldBadIfElse().getType();
        [Benchmark] public string TypeCheckingTypeFieldBadSwitch_getType() => new TypeCheckingTypeFieldBadSwitch().getType();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<AllLinterEx>( args: args);

            //var summary = BenchmarkRunner.Run<LinterExperiments>(args:args);
            //var summary = BenchmarkRunner.Run(typeof(LinterProgram).Assembly, args: args);
            //var othersum = BenchmarkSwitcher.FromAssembly(typeof(LinterProgram).Assembly).Run(args: args);
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
        public double Good()
        {
            return good.DeadLocalStore(0.4250);
        }

        [Benchmark]
        public double Bad()
        {
            return bad.DeadLocalStore(0.4250);
        }
    }
}