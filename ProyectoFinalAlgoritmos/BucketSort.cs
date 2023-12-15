// BucketSort.cs

using System;
using System.Collections.Generic;

public class BucketSort
{
    public static int[] Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
            return array;

        int minValue = array[0];
        int maxValue = array[0];

        // Encuentra los valores mínimo y máximo en el array
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
                minValue = array[i];
            else if (array[i] > maxValue)
                maxValue = array[i];
        }

        // Crea los buckets
        List<int>[] buckets = new List<int>[maxValue - minValue + 1];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        // Distribuye los elementos en los buckets
        for (int i = 0; i < array.Length; i++)
        {
            buckets[array[i] - minValue].Add(array[i]);
        }

        // Ordena cada bucket y combina los resultados
        List<int> result = new List<int>();
        foreach (var bucket in buckets)
        {
            if (bucket.Count > 0)
            {
                int[] bucketArray = Sort(bucket.ToArray());
                result.AddRange(bucketArray);
            }
        }

        return result.ToArray();
    }
}

