namespace LinterExperiments
{
    namespace Smells.CodeSmellExamples
    {
        public class DeadCodeGood : DeadCodeBase
        {
            [BenchmarkCategory("smells")][Benchmark] public override void Run()
            {
                int a = 5;
                int b = 10;

                double c = Math.Sqrt(Math.Pow(2, a) + Math.Pow(2, b));

                // make sure eval is done in good version as well for fairness
                if (a > b) c = c * 2;
            }
        }
    }
}