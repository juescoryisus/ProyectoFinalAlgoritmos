public class CocktailSort
{
    public static void Sort(int[] array)
    {
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(ref array[i], ref array[i + 1]);
                    swapped = true;
                }
            }

            if (!swapped)
                break;

            swapped = false;
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(ref array[i], ref array[i + 1]);
                    swapped = true;
                }
            }
        } while (swapped);
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

