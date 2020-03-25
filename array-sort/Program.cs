using System;

namespace ArraySort
{
    public class Program
    {
        private static int[] Filling(int size)
        {
            int[] array = new int[size];
            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 101);
            }
            Console.WriteLine("Array initialized:");
            return array;
        }

        private static void Conclusion(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        private static int[] Sorting(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            { // пузырьковая сортировка
                for (int i = 0; i < array.Length - 1; i++)
                {

                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort:");
            return array;
        }

        private static void Main()
        {
            Console.WriteLine("Enter size of the array, please:");
            int size = int.Parse(Console.ReadLine());
            int[] array = Filling(size);
            Conclusion(array);
            Sorting(array);
            Conclusion(array);
        }
    }
}