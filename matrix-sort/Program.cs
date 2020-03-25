using System;

namespace MatrixSort
{
    public class Program
    {
        private static int[,] Filling(int lineSize, int columnSize)
        {
            var rnd = new Random();
            int[,] matrix = new int[lineSize, columnSize];
            Console.WriteLine("matrix");
            for (int i = 0; i < lineSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    matrix[i, j] = rnd.Next(0, 101); // заполнение матрицы
                }
            }
            Console.WriteLine("Matrix initialized:");
            return matrix;
        }

        private static void Conclusion(int[,] matrix, int linesSize, int columnSize)
        {
            for (int i = 0; i < linesSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] Sorting(int[,] matrix, int linesSize, int columnSize)
        {
            int n = linesSize - 1;
            while (n > 0) // сортировка столбцов матрицы по первым элементам
            {
                int index = 0;
                for (int j = 0; j <= n; j++)
                {
                    if (matrix[0, j] > matrix[0, index])
                    {
                        index = j; // поиск индекса столбца максимального элемента
                    }
                }
                for (int i = 0; i < columnSize; i++)
                {
                     int temp = matrix[i, index];
                    matrix[i, index] = matrix[i, n]; // меняем элементы столбцов местами
                    matrix[i, n] = temp;
                }
                n -= 1;
            }
            Console.WriteLine("Matrix sorted:");
            return matrix;
        }

        private static void Main()
        {
            Console.WriteLine("Enter the size lines of matrix");
            var linesSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size column of matrix");
            var columnsSize = int.Parse(Console.ReadLine());
            int[,] matrix = Filling(linesSize, columnsSize);
            Conclusion(matrix, linesSize, columnsSize);
            Sorting(matrix, columnsSize, linesSize);
            Conclusion(matrix, linesSize, columnsSize);
        }
    }
}