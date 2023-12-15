public class QuickSort
{
    public static void Sort(int[] array)
    {
        if (array == null || array.Length == 0)
            return;

        QuickSortAlgorithm(array, 0, array.Length - 1);
    }

    private static void QuickSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);

            if (pivotIndex > 1)
                QuickSortAlgorithm(array, left, pivotIndex - 1);

            if (pivotIndex + 1 < right)
                QuickSortAlgorithm(array, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[left];
        while (true)
        {
            while (array[left] < pivot)
                left++;

            while (array[right] > pivot)
                right--;

            if (left < right)
            {
                Swap(array, left, right);
            }
            else
            {
                return right;
            }
        }
    }

    private static void Swap(int[] array, int left, int right)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;
    }
}
