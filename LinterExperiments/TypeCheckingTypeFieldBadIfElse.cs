namespace LinterExperiments
{
    class TypeCheckingTypeFieldBadIfElse : TypeCheckingBase
    {
        private Employee obj { get; set; }
        private const int SALESMAN = 0;
        private const int ENGINEER = 1;
        private const int DIRECTOR = 2;

        [Benchmark] public override string getType()
        {
            // user defined getType method
            if (this.obj.getTypeField() == ENGINEER) return "Engineer";
            else if (this.obj.getTypeField() == SALESMAN) return "Salesman";
            else if (this.obj.getTypeField() == DIRECTOR) return "Director";
            else return "Error";
        }

        public override void SetObj(Employee newObj)
        {
            obj = newObj;
        }
    }
}