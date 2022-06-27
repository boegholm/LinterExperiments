namespace LinterExperiments
{
    public class LongMethodGood : LongMethodBase
    {
        private int[] arr;
        private int ARR_SIZE = 10;

        public override void Compute()
        {
            CreateArray();
            //PrintArray();

            BubbleSort();
            //PrintArray();

            SumArray();

            InvertArray();
            //PrintArray();

            MultiplyArray();
            //PrintArray();

            arr = null;
        }

        public void CreateArray()
        {
            Random rand = new Random();

            arr = new int[ARR_SIZE];

            for (int i = 0; i < ARR_SIZE; i++) arr[i] = rand.Next(50);
        }

        public void PrintArray()
        {
            Console.WriteLine("{ " + String.Join(", ", arr) + " }");
        }

        public void BubbleSort()
        {
            for (int i = 0; i < ARR_SIZE - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < ARR_SIZE; j++)
                    if (arr[j] < arr[min])
                        min = j;

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        public void SumArray()
        {
            int total = 0;
            for (int i = 0; i < ARR_SIZE; i++)
                total += arr[i];
        }

        public void InvertArray()
        {
            int upper;
            int lower;
            for (int i = 0; i < ARR_SIZE / 2; i++)
            {
                lower = arr[i];
                upper = arr[ARR_SIZE - i - 1];
                arr[i] = upper;
                arr[ARR_SIZE - i - 1] = lower;
            }
        }

        public void MultiplyArray()
        {
            int x = 5;
            for (int i = 0; i < ARR_SIZE; i++)
            {
                arr[i] = arr[i] * x;
            }
        }
    }
}