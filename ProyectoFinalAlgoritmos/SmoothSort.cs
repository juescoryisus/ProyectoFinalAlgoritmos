// SmoothSort.cs
using System;

public class SmoothSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int j = i;

            while (j > 0 && arr[j] < arr[(j - 1) / 2])
            {
                Swap(arr, j, (j - 1) / 2);
                j = (j - 1) / 2;
            }
        }

        for (int i = n - 1; i > 0; i--)
        {
            Swap(arr, 0, i);

            int j = 0;
            int child;

            while ((child = 2 * j + 1) < i)
            {
                if (child + 1 < i && arr[child] < arr[child + 1])
                    child++;

                if (arr[j] < arr[child])
                {
                    Swap(arr, j, child);
                    j = child;
                }
                else
                {
                    break;
                }
            }
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}

