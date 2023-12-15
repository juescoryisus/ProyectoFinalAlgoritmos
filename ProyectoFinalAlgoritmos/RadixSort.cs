// RadixSort.cs
using System;

namespace RadixSortExample
{
    public class RadixSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int max = GetMax(arr);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(arr, n, exp);
            }
        }

        private static void CountSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        private static int GetMax(int[] arr)
        {
            int max = arr[0];
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
