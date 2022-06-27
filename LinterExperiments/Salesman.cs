namespace LinterExperiments
{
    public class Salesman : Employee
    {
        private int salary = 100000;

        public override int getTypeField()
        {
            return this.SALESMAN;
        }

        public override string getTypeString()
        {
            return "Salesman";
        }
    }
}