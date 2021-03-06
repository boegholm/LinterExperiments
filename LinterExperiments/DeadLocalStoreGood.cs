namespace LinterExperiments
{

    namespace Smells.CodeSmellExamples
    {
        public class DeadLocalStoreGood : DeadLocalStoreBase
        {
            public override double Run()
            {
                return DeadLocalStore(23.42);
            }
            public override double DeadLocalStore(double radius)
            {
                double pi = 3.14;

                return (pi * Math.Pow(2, radius));
            }
        }
    }
}