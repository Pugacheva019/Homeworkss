using System;

namespace MatrixSort
{
    public class Program
    {
        private static int[,] Filling(int lineSize, int columnSize)
        {
            var rnd = new Random();
            int[,] matrix = new int[lineSize, columnSize];
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

        private static void Conclusion(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] Sorting(int[,] matrix)
        {
            int n = matrix.GetLength(1) - 1;
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
                for (int i = 0; i < matrix.GetLength(0); i++)
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
            Conclusion(matrix);
            Sorting(matrix);
            Conclusion(matrix);
        }
    }
}
