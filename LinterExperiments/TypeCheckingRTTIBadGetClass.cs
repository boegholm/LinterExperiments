namespace LinterExperiments
{
    public class TypeCheckingRTTIBadGetClass : TypeCheckingBase
    {
        private Employee obj { get; set; }
        public override string getType()
        {
            // built-in GetType method
            if (obj.GetType() == typeof(Engineer)) return "Engineer";
            else if (obj.GetType() == typeof(Salesman)) return "Salesman";
            else if (obj.GetType() == typeof(Director)) return "Director";
            else return "Error";
        }

        public override void SetObj(Employee newObj)
        {
            obj = newObj;
        }
    }
}