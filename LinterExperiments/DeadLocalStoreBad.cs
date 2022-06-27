namespace LinterExperiments
{

    namespace Smells.CodeSmellExamples
    {
        public class DeadLocalStoreBad : DeadLocalStoreBase
        {
            public override double Run()
            {
                return DeadLocalStore(23.42);
            }
             public override double DeadLocalStore(double radius)
            {
                double pi = 3.14;
                double notPi = 4.13;
                int cousinsAgeInMonths = 146;
                string niceGreeting = "Hellow World";

                return (pi * Math.Pow(2, radius));
            }
        }
    }
}