using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    class Solution
    {
        static int numberOfSwaps = 0;

        static bool IsSorted(int[] a)
        {

            for (int i = 0; i < a.Length - 1; i++)
            {

                if (a[i] > a[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void BubbleSort(int[] a)
        {

            var temp = 0;

            while (!IsSorted(a))
            {

                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        numberOfSwaps++;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            BubbleSort(a);

            Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[a.Length - 1]);
        }
    }
}
