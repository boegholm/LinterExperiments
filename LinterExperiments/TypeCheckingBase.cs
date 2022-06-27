namespace LinterExperiments
{
    public abstract class TypeCheckingBase
    {
        protected Employee obj { get; set; } = new Engineer();
        public abstract string getType();
        public abstract void SetObj(Employee newObj);
    }
}