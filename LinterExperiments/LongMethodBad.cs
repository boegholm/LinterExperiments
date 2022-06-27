﻿namespace LinterExperiments
{
    public class LongMethodBad : LongMethodBase
    {
        private int[] arr;
        private int ARR_SIZE = 10;
        [BenchmarkCategory("smells")][Benchmark] public override void Compute()
        {
            // make array
            Random rand = new Random();

            arr = new int[ARR_SIZE];

            for (int i = 0; i < ARR_SIZE; i++) arr[i] = rand.Next(50);

            //Console.WriteLine("{ " + String.Join(", ", arr) + " }");

            // sort array

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

            //Console.WriteLine("{ " + String.Join(", ", arr) + " }");

            // sum array
            int total = 0;
            for (int i = 0; i < ARR_SIZE; i++)
            {
                total += arr[i];
            }

            // invert array
            int upper;
            int lower;
            for (int i = 0; i < ARR_SIZE / 2; i++)
            {
                lower = arr[i];
                upper = arr[ARR_SIZE - i - 1];
                arr[i] = upper;
                arr[ARR_SIZE - i - 1] = lower;
            }

            //Console.WriteLine("{ " + String.Join(", ", arr) + " }");

            // multiply array by x
            int x = 5;
            for (int i = 0; i < ARR_SIZE; i++)
            {
                arr[i] = arr[i] * x;
            }

            // reset array
            arr = null;
        }
    }
}