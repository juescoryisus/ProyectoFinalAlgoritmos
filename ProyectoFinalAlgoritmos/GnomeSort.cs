// GnomeSort.cs
public class GnomeSort
{
    public static void Sort(int[] array)
    {
        int index = 0;

        while (index < array.Length)
        {
            if (index == 0 || array[index] >= array[index - 1])
            {
                index++;
            }
            else
            {
                Swap(ref array[index], ref array[index - 1]);
                index--;
            }
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

