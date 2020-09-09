using System;

namespace Spiral
{
    public class Program
    {
        private static int[,] Filling(int size)
        {
            var rnd = new Random();
            int[,] matrix = new int[size, size];
            Console.WriteLine("matrix");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rnd.Next(0, 101); // заполнение матрицы
                }
            }
            Console.WriteLine("Matrix initialized:");
            return matrix;
        }

        private static void Printing(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Spiral(int[,] matrix)
        {
            int shift = 1; // cдвиг
            int line = matrix.GetLength(0) / 2;
            int column = matrix.GetLength(0) / 2; // координаты центрального элемента
            Console.WriteLine(" Matrix's elements for a spiral:");
            Console.Write(matrix[line, column] + " ");
            while (shift <= matrix.GetLength(0))
            {
                for (int k = 0; k < shift; k++)
                {
                    if (line == 0 && column == 0) // для последнего сдвига, чтобы не выходить за границы массива
                    {
                        break;
                    }
                    else
                    {
                        line -= 1;
                        Console.Write(matrix[line, column] + " ");
                    }
                }
                if (shift == matrix.GetLength(0))
                {
                    break; // для последнего сдвига, чтобы не выходить за границы массива
                }
                for (int k = 0; k < shift; k++)
                {
                    column += 1;
                    Console.Write(matrix[line, column] + " ");
                }
                shift++;
                for (int k = 1; k <= shift; k++)
                {
                    line += 1;
                    Console.Write(matrix[line, column] + " ");
                }
                for (int k = 1; k <= shift; k++)
                {
                    column -= 1;
                    Console.Write(matrix[line, column] + " ");
                }
                shift++;
            }
        }

        private static void Main()
        {
            Console.WriteLine("Enter the size of matrix");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = Filling(size);
            Console.WriteLine(matrix.GetLength(0));
            Printing(matrix);
            Spiral(matrix);
        }
    }
}