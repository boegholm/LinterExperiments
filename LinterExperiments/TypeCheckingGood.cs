namespace LinterExperiments
{
    public class TypeCheckingGood : TypeCheckingBase
    {

        public override string getType()
        {
            return obj.getTypeString();
        }

        public override void SetObj(Employee newObj)
        {
            obj = newObj;
        }
    }
}