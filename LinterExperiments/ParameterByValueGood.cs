namespace LinterExperiments
{
    public class ParameterByValueGood : ParameterByValueBase
    {
        public override void ParameterByValue()
        {
            int a = 100;
            int b = 50;

            int c = Compute(ref a, ref b);
        }
    }
}