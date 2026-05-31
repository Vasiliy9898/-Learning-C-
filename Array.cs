using System;

namespace Sharp;
    class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Введите элемент массива : ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);


        BubbleSort(numbers);

        Console.WriteLine("Отсортированный массив :");
        PrintArray(numbers);
    }


    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }
}
