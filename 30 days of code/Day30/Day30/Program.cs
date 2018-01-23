using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30
{
    class Solution
    {
        static int FindLargestSuitableInt(int n, int k)
        {
            int temp = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    var bitwiseResult = i & j;
                    if (bitwiseResult < k && bitwiseResult > temp)
                    {
                        temp = bitwiseResult;
                    }
                }
            }
            return temp;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] tokens_n;
            int n;
            int k;

            for (int a0 = 0; a0 < t; a0++)
            {
                tokens_n = Console.ReadLine().Split(' ');
                n = Convert.ToInt32(tokens_n[0]);
                k = Convert.ToInt32(tokens_n[1]);
                Console.WriteLine(FindLargestSuitableInt(n, k));
            }

            Console.ReadKey();
        }
    }
}
