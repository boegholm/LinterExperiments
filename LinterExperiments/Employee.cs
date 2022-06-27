namespace LinterExperiments
{
    public abstract class Employee
    {
        public int SALESMAN = 0;
        public int ENGINEER = 1;
        public int DIRECTOR = 2;
        private int salary;

        public abstract int getTypeField();
        public abstract string getTypeString();
    }
}