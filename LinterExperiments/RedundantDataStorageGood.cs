namespace LinterExperiments
{
    public class RedundantDataStorageGood : RedundantDataStorageBase
    {
        private int[] arr = {12, 42, 54, 1, 29, 390, 2, 39, 5849, 30, 1034, 439, 3228, 20, 392, 4832,
                            203, 39, 3489, 498, 304, 32, 4930, 849, 182, 3892, 483, 37, 19, 93, 83};
        [Benchmark] public override int[] ReverseList()
        {
            int upper;
            int lower;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                lower = arr[i];
                upper = arr[arr.Length - i - 1];
                arr[i] = upper;
                arr[arr.Length - i - 1] = lower;
            }

            return arr;
        }

        [Benchmark] public override int[] SortList()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min])
                        min = j;

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        [Benchmark] public override int SumList()
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
                total += arr[i];

            return total;
        }
    }
}