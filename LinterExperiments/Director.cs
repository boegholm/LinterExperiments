namespace LinterExperiments
{
    public class Director : Employee
    {
        private int salary = 1000000000;

        public override int getTypeField()
        {
            return this.DIRECTOR;
        }

        public override string getTypeString()
        {
            return "Director";
        }
    }
}