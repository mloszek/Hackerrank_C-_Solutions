using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Solution
    {
        static void PrintStaircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            PrintStaircase(n);
            Console.ReadKey();
        }
    }
}
