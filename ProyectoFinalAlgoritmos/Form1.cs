using MergeSortApp;
using RadixSortExample;
using SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAlgoritmos
{
    public partial class Form1 : Form
    {
        private BinaryTree binaryTree;
        private int[] arrayToSort;
        private int[] arrayToSort1;
        private TextBox txtNumbers;
        private Button btnSort14;
        public Form1()
        {
            InitializeComponent();
            binaryTree = new BinaryTree();

            txtNumbers2345 = new TextBox
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(200, 20)
            };
            Controls.Add(txtNumbers2345);

            btnSort14 = new Button
            {
                Location = new System.Drawing.Point(220, 10),
                Size = new System.Drawing.Size(75, 23),
                Text = "Ordenar"
            };
            btnSort14.Click += btnSort_Click;
            Controls.Add(btnSort14);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                binaryTree.Insert(number);
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese Un Numero Etero.");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<int> sortedList = binaryTree.InOrderTraversal();
            MessageBox.Show("Numeros Ordenados: " + string.Join(", ", sortedList));
        }

        private void btnSortBubble_Click(object sender, EventArgs e)
        {
            // Leer los números desde el cuadro de texto y convertirlos a un array
            string[] numbersString = txtNumbers2345.Text.Split(',');
            int[] numbers = Array.ConvertAll(numbersString, int.Parse);

            // Aplicar Bubble Sort
            BubbleSort.Sort(numbers);

            // Mostrar los números ordenados en el cuadro de texto.
            MessageBox.Show("Numeros Ordenados: " + string.Join(", ", numbers));
        }

        private void btnSortBucket_Click(object sender, EventArgs e)
        {
            // Obtén los números ingresados por el usuario desde el TextBox
            string input = txtInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Ingrese al menos un número.", "Error");
                return;
            }

            // Convierte la cadena de entrada en una matriz de enteros
            int[] arrayToSort;
            try
            {
                arrayToSort = input.Split(',').Select(int.Parse).ToArray();
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de entrada incorrecto. Ingrese números separados por comas.", "Error");
                return;
            }

            // Ordena la matriz utilizando BucketSort
            int[] sortedArray = BucketSort.Sort(arrayToSort);

            // Muestra el resultado en un MessageBox
            MessageBox.Show("Array ordenado: " + string.Join(", ", sortedArray), "Resultado");
        }

        private void btnSortCocktailSort_Click(object sender, EventArgs e)
        {
            if (arrayToSort != null)
            {
                CocktailSort.Sort(arrayToSort);
                DisplaySortedArray();
            }
            else
            {
                MessageBox.Show("Por favor genere una matriz primero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerateArray_Click(object sender, EventArgs e)
        {
            int arraySize;
            if (int.TryParse(txtArraySize.Text, out arraySize))
            {
                Random rand = new Random();
                arrayToSort = new int[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    arrayToSort[i] = rand.Next(1, 100);
                }

                DisplayOriginalArray();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un tamaño de matriz válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayOriginalArray()
        {
            lblOriginalArray.Text = "Matriz original: " + string.Join(", ", arrayToSort);
            lblSortedArray.Text = "Matriz ordenada: ";
        }
        private void DisplaySortedArray()
        {
            lblSortedArray.Text = "Matriz ordenada: " + string.Join(", ", arrayToSort);
        }

        private void btnSortCombsort_Click(object sender, EventArgs e)
        {
            // Read numbers from the input TextBox
            string inputText = txtInput1.Text;
            string[] numberStrings = inputText.Split(',');

            // Convert string array to int array
            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);

            // Use Combsort to sort the array
            Combsort.Sort(numbers);

            // Display sorted numbers in the output TextBox or label
            txtOutput1.Text = string.Join(", ", numbers);
        }

        private void btnSortCountingSort_Click(object sender, EventArgs e)
        {
            // Obtener los datos del textbox y convertirlos a un array de enteros
            string[] inputArray = txtInput2.Text.Split(',');
            int[] array = Array.ConvertAll(inputArray, int.Parse);

            // Aplicar Counting Sort al array
            CountingSort.Sort(array);

            // Mostrar el resultado en el textbox de salida
            txtOutput2.Text = string.Join(", ", array);
        }

        private void btnSortGnomeSort_Click(object sender, EventArgs e)
        {
            if (arrayToSort != null && arrayToSort.Length > 0)
            {
                GnomeSort.Sort(arrayToSort);
                DisplaySortedArray();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers to sort.");
            }
        }

        private void btnGenerateArray1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput3.Text, out int arraySize))
            {
                Random random = new Random();
                arrayToSort = new int[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    arrayToSort[i] = random.Next(1, 100); // Adjust range as needed
                }

                DisplayOriginalArray1();
            }
            else
            {
                MessageBox.Show("Please enter a valid array size.");
            }
        }
        private void DisplayOriginalArray1()
        {
            lblOriginalArray3.Text = $"Original Array: {string.Join(", ", arrayToSort)}";
            lblSortedArray4.Text = "Sorted Array: ";
        }

        private void DisplaySortedArray1()
        {
            lblSortedArray4.Text = $"Sorted Array: {string.Join(", ", arrayToSort)}";
        }

        private void btnSortHeapSort_Click(object sender, EventArgs e)
        {
            // Obtener los elementos del TextBox y convertirlos a un arreglo de enteros
            string[] inputArray = txtInput8.Text.Split(',');
            int[] arr = Array.ConvertAll(inputArray, s => int.Parse(s));

            // Aplicar Heapsort
            HeapSort heapSort = new HeapSort();
            heapSort.Sort(arr);

            // Mostrar el resultado en el TextBox de salida
            txtOutput9.Text = string.Join(", ", arr);
        }

        private void btnSortInsertionsort_Click(object sender, EventArgs e)
        {
            // Get input from the user
            string input = txtInput34.Text;

            // Parse the input string into an array of integers
            int[] arrayToSort = input.Split(',').Select(int.Parse).ToArray();

            // Use Insertion Sort to sort the array
            InsertionSort.Sort(arrayToSort);

            // Display the sorted array in a MessageBox
            MessageBox.Show("Sorted Array: " + string.Join(", ", arrayToSort), "Insertion Sort");
        }

        private void btnSortMergesort_Click(object sender, EventArgs e)
        {
            // Obtener los elementos del cuadro de texto y convertirlos a un array
            string[] inputArray = txtInput12.Text.Split(',');

            // Convertir los elementos a enteros
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            // Aplicar el algoritmo Mergesort
            Mergesort.Sort(numbers);

            // Mostrar el resultado en el cuadro de texto de salida
            txtOutput11.Text = string.Join(", ", numbers);
        }

        private void btnSortPigeonholeSort_Click(object sender, EventArgs e)
        {
            // Obtener los números ingresados por el usuario desde el TextBox
            string input = txtInputNumbers88.Text;

            // Convertir la cadena de entrada a un arreglo de enteros
            string[] numberStrings = input.Split(',');
            int[] arrayToSort = new int[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int num))
                {
                    arrayToSort[i] = num;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese números separados por comas.", "Error de entrada");
                    return;
                }
            }

            // Llamada al método de ordenamiento
            PigeonholeSort.Sort(arrayToSort);

            // Mostrar el arreglo ordenado
            string sortedArray = string.Join(", ", arrayToSort);
            MessageBox.Show($"Arreglo ordenado: {sortedArray}", "Resultado");
        }

        private void btnSortQuickSort_Click(object sender, EventArgs e)
        {
            // Supongamos que tienes un TextBox llamado txtInput que contiene los números a ordenar.
            string[] inputArray = txtInput67.Text.Split(',');
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            QuickSort.Sort(numbers);

            // Supongamos que tienes un TextBox llamado txtOutput para mostrar los resultados.
            txtOutput43.Text = string.Join(", ", numbers);
        }

        private void btnSortRadixSor_Click(object sender, EventArgs e)
        {
            // Obtener los números ingresados por el usuario desde el cuadro de texto
            string input = txtInputNumbers76.Text;

            // Convertir la cadena de entrada en un array de enteros
            int[] arr = ParseInput(input);

            // Llamada al método de Radix Sort
            RadixSort.Sort(arr);

            // Mostrar el resultado en el cuadro de texto de salida (puedes adaptarlo a tu interfaz gráfica)
            txtSortedNumbers09.Text = string.Join(", ", arr.Select(x => x.ToString()));
        }
        private int[] ParseInput(string input)
        {
            try
            {
                // Dividir la cadena por comas y convertir los segmentos en enteros
                return input.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            }
            catch (Exception)
            {
                // Manejar errores de conversión
                MessageBox.Show("Por favor, ingrese números válidos separados por comas.");
                return new int[0];
            }
        }

        private void btnSortSelectionsort_Click(object sender, EventArgs e)
        {
            // Verifica si se han ingresado números en el TextBox
            if (string.IsNullOrWhiteSpace(txtNumbers98.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Parsea los números ingresados por el usuario
                int[] arrayToSort = txtNumbers98.Text.Split(',').Select(int.Parse).ToArray();

                // Llama al método de ordenación
                SelectionSort.Sort(arrayToSort);

                // Muestra el arreglo ordenado en el Label
                lblSortedArray73.Text = "Sorted array: " + string.Join(", ", arrayToSort);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSortShellSort_Click(object sender, EventArgs e)
        {
            // Obtener los elementos del cuadro de texto y convertirlos a un array de enteros
            string[] inputArray = txtInput732.Text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arrayToSort = Array.ConvertAll(inputArray, int.Parse);

            // Ordenar el array utilizando Shellsort
            ShellSort(arrayToSort);

            // Mostrar el array ordenado en el cuadro de texto de salida
            txtOutput843.Text = string.Join(",", arrayToSort);
        }
        // Implementación del algoritmo Shellsort
        private void ShellSort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }

        private void btnSortSmoothSort_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener números ingresados por el usuario y convertirlos a un arreglo
                int[] arrayToSort = txtNumbers2345.Text.Split(',')
                                                  .Select(str => int.Parse(str.Trim()))
                                                  .ToArray();

                Console.WriteLine("Arreglo sin ordenar:");
                PrintArray(arrayToSort);

                SmoothSort.Sort(arrayToSort);

                Console.WriteLine("\nArreglo ordenado:");
                PrintArray(arrayToSort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los números. Asegúrate de ingresar números separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintArray(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
    
}
