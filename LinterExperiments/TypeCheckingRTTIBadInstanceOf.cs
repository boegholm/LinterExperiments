namespace LinterExperiments
{
    public class TypeCheckingRTTIBadInstanceOf : TypeCheckingBase
    {
        public override string getType()
        {
            // built-in GetType method
            if (obj is Engineer) return "Engineer";
            else if (obj is Salesman) return "Salesman";
            else if (obj is Director) return "Director";
            else return "Error";
        }

        public override void SetObj(Employee newObj)
        {
            obj = newObj;
        }
    }
}