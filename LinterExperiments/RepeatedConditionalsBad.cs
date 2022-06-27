namespace LinterExperiments
{
    public class RepeatedConditionalsBad : RepeatedConditionalsBase
    {
        [Benchmark] public override void RepeatedConditionals()
        {
            int a = 100;
            int b = 200;
            int c = 20;
            int d = 0;

            if (a * c > b)
            {
                d = b + a;
            }

            if (a * c > b)
            {
                b = d * c;
            }

            d = a * c + b;
        }
    }
}