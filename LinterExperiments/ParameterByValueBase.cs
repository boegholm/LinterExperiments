namespace LinterExperiments
{
    public abstract class ParameterByValueBase
    {
        public abstract void ParameterByValue();
        public int Compute(int a, int b)
        {
            int c = a * b;

            if (a > b) c = c + b;

            b = b * 2;

            return c;
        }

        public int Compute(ref int a, ref int b)
        {
            int c = a * b;

            if (a > b) c = c + b;

            b = b * 2;

            return c;
        }
    }
}