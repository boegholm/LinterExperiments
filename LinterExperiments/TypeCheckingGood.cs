namespace LinterExperiments
{
    public class TypeCheckingGood : TypeCheckingBase
    {
        private Employee obj { get; set; }

        [Benchmark] public override string getType()
        {
            return obj.getTypeString();
        }

        public override void SetObj(Employee newObj)
        {
            obj = newObj;
        }
    }
}