namespace LinterExperiments
{
    public class ParameterByValueBad : ParameterByValueBase
    {
        public override void ParameterByValue()
        {
            int a = 100;
            int b = 50;

            int c = Compute(a, b);
        }
    }
}