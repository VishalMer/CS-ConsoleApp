using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class seprateEvenOdd
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] inputArray = new int[n];
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                inputArray[i] = Int32.Parse(Console.ReadLine());

                if (inputArray[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            int[] evenAry = new int[evenCount];
            int[] oddAry = new int[oddCount];
            evenCount = 0;
            oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    evenAry[evenCount] = inputArray[i];
                    evenCount++;
                }
                else
                {
                    oddAry[oddCount] = inputArray[i];
                    oddCount++;
                }
            }

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenAry.Length; i++)
            {
                Console.WriteLine(evenAry[i]);
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < oddAry.Length; i++)
            {
                Console.WriteLine(oddAry[i]);
            }
        }
    }
}
