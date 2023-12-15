public class HeapSort
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;

        // Construir el heap (reorganizar el arreglo)
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        // Extraer elementos del heap uno por uno
        for (int i = n - 1; i > 0; i--)
        {
            // Mover la raíz actual al final
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            // Llamar a heapify en el subárbol reducido
            Heapify(arr, i, 0);
        }
    }

    void Heapify(int[] arr, int n, int i)
    {
        int largest = i; // Inicializar el más grande como la raíz
        int left = 2 * i + 1; // índice del hijo izquierdo
        int right = 2 * i + 2; // índice del hijo derecho

        // Si el hijo izquierdo es más grande que la raíz
        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        // Si el hijo derecho es más grande que el más grande hasta ahora
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        // Si el más grande no es la raíz
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            // Recursivamente heapify el subárbol afectado
            Heapify(arr, n, largest);
        }
    }
}

