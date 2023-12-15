using System;

public class Combsort
{
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        int gap = array.Length;
        bool swapped = true;

        while (gap > 1 || swapped)
        {
            // Reduce gap according to shrink factor
            gap = GetNextGap(gap);

            // Initialize swapped as false so that we can
            // check if the array is already sorted
            swapped = false;

            // Compare all elements with the current gap
            for (int i = 0; i < array.Length - gap; i++)
            {
                int j = i + gap;

                if (array[i].CompareTo(array[j]) > 0)
                {
                    // Swap array[i] and array[j]
                    Swap(ref array[i], ref array[j]);
                    swapped = true;
                }
            }
        }
    }

    private static int GetNextGap(int gap)
    {
        // Shrink factor
        const double shrink = 1.3;

        gap = (int)(gap / shrink);

        return gap > 1 ? gap : 1;
    }

    private static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
