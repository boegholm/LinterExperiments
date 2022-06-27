namespace LinterExperiments
{
    public abstract class RedundantDataStorageBase
    {
        public abstract int SumList();
        public abstract int[] SortList();
        public abstract int[] ReverseList();

        public void Run()
        {
            int total = SumList();
            int[] sorted = SortList();
            int[] reversed = ReverseList();
        }
    }
}