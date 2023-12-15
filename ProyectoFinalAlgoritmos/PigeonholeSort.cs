using System;
using System.Collections.Generic;

public class PigeonholeSort
{
    public static void Sort(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        int range, i, j, index;

        for (int a = 0; a < arr.Length; a++)
        {
            if (arr[a] > max)
                max = arr[a];
            if (arr[a] < min)
                min = arr[a];
        }

        range = max - min + 1;
        List<int>[] pigeonhole = new List<int>[range];

        for (i = 0; i < range; i++)
        {
            pigeonhole[i] = new List<int>();
        }

        for (i = 0; i < arr.Length; i++)
        {
            pigeonhole[arr[i] - min].Add(arr[i]);
        }

        index = 0;
        for (i = 0; i < range; i++)
        {
            List<int> list = pigeonhole[i];
            for (j = 0; j < list.Count; j++)
            {
                arr[index++] = list[j];
            }
        }
    }
}
