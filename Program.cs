using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many columns and lines? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"[{i}, {j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] neg = new int[20];
            int count = 0;
            Console.Write("\nDiagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                    
                    if (i == j) { Console.Write(mat[i, j] + " "); }
                    if (mat[i, j] < 0) 
                    { 
                        neg[count] = mat[i, j];
                        count++;
                    }
                }
            }
            Console.WriteLine();

            Console.Write("\nNegativos: ");
            for (int i = 0; i < neg.Length; i++)
            {
                if (neg[i] != 0)
                {
                    Console.Write(neg[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
