namespace LinterExperiments
{
    public class RepeatedConditionalsGood : RepeatedConditionalsBase
    {
        public override void RepeatedConditionals()
        {
            int a = 100;
            int b = 200;
            int c = 20;
            int d = 0;

            if (a * c > b)
            {
                d = b + a;
                b = d * c;
            }

            d = a * c + b;
        }
    }
}