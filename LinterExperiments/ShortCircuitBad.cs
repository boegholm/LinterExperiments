namespace LinterExperiments
{
    public class ShortCircuitBad : ShortCircuitBase
    {
        [BenchmarkCategory("smells")][Benchmark] public override void ShortCircuit()
        {
            int a = 100;
            int b = 1000;
            int c = 5;

            if (b > a | a > c) a = a * c;

            if (a > b & b == 1000) a = a * c;
        }
    }
}