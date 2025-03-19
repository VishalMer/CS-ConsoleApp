using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23FOTCA11030_Vishal.Q2
{
    internal class MergeArrays
    {
        static void Main()
        {
            int[] arr1 = { 1, 3, 5, 7 };
            int[] arr2 = { 2, 4, 6, 8 };
            int[] mergedArray = new int[arr1.Length + arr2.Length];

            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j]) 
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }

            while (i < arr1.Length)
            {
                mergedArray[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                mergedArray[k++] = arr2[j++];
            }

            Console.WriteLine("Merged Sorted Array:");
            for (int x = 0; x < mergedArray.Length; x++) 
            {
                Console.Write(mergedArray[x] + " ");
            }
        }
    }
}
