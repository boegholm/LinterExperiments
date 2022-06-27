namespace LinterExperiments
{
    public class Engineer : Employee
    {
        public int _type;
        private int salary = 40000;

        public override int getTypeField()
        {
            return this.ENGINEER;
        }

        public override string getTypeString()
        {
            return "Engineer";
        }
    }
}