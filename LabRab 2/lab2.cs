using System;

namespace lab2
{
    internal class Lab2
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.Write("Rows 'n' columns(number):");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            Console.WriteLine("Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"   {matrix[i, j]}");
                }
                Console.WriteLine();
            }
            double max = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
            }
            Console.WriteLine($"Max elem = {max}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == max)
                        matrix[i, j] = 0;
                }
            }
            Console.WriteLine("Matrix with max elem changed to zero:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"   {matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}