using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26
{
    class Solution
    {
        static string CheckForPrimality(int a)
        {

            if (a < 2)
            {
                return "Not prime";
            }
            else if (a == 2)
            {
                return "Prime";
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return "Not prime";
                    }
                }
                return "Prime";
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(CheckForPrimality(Convert.ToInt32(Console.ReadLine())));
            }
        }
    }
}
