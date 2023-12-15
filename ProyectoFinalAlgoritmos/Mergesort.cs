namespace MergeSortApp
{
    public static class Mergesort
    {
        public static void Sort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int middle = array.Length / 2;

            // Dividir el array en dos partes
            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
                left[i] = array[i];

            for (int i = middle; i < array.Length; i++)
                right[i - middle] = array[i];

            // Recursivamente ordenar ambas partes
            Sort(left);
            Sort(right);

            // Combinar las dos partes ordenadas
            Merge(array, left, right);
        }

        private static void Merge(int[] result, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copiar los elementos restantes de left (si hay alguno)
            while (i < left.Length)
            {
                result[k] = left[i];
                i++;
                k++;
            }

            // Copiar los elementos restantes de right (si hay alguno)
            while (j < right.Length)
            {
                result[k] = right[j];
                j++;
                k++;
            }
        }
    }
}

