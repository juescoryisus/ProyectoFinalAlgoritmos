public class CountingSort
{
    public static void Sort(int[] array)
    {
        int max = FindMax(array);
        int[] count = new int[max + 1];
        int[] output = new int[array.Length];

        // Inicializar el array de conteo
        for (int i = 0; i < count.Length; i++)
        {
            count[i] = 0;
        }

        // Contar la frecuencia de cada elemento
        for (int i = 0; i < array.Length; i++)
        {
            count[array[i]]++;
        }

        // Actualizar el array de conteo para contener las posiciones reales de los elementos en el output
        for (int i = 1; i <= max; i++)
        {
            count[i] += count[i - 1];
        }

        // Construir el array de salida
        for (int i = array.Length - 1; i >= 0; i--)
        {
            output[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        // Copiar el array de salida de nuevo al array original
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = output[i];
        }
    }

    private static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
