using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class AddMatrices
    {
        public static void Main(string[] args)
        {

            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int[,] sumMatrix = new int[2, 2];

            Console.WriteLine("Enter elements for the first matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    matrix1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements for the second matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    matrix2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("Sum of the two matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
