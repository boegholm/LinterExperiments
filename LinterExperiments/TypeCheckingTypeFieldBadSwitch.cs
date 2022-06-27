namespace LinterExperiments
{
    public class TypeCheckingTypeFieldBadSwitch : TypeCheckingBase
    {
        private const int SALESMAN = 0;
        private const int ENGINEER = 1;
        private const int DIRECTOR = 2;

        public override string getType()
        {
            // user defined getType method
            switch (this.obj.getTypeField())
            {
                case ENGINEER:
                    return "Engineer";
                case SALESMAN:
                    return "Salesman";
                case DIRECTOR:
                    return "Director";
                default:
                    return "Error";
            }
        }

        public override void SetObj(Employee newObj)
        {
            obj = newObj;
        }
    }
}