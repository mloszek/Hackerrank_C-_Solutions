using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Solution
    {
        static string[] numbers;

        static long CalculateSum()
        {
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt64(numbers[i]);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
            numbers = Console.ReadLine().Split(' ');

            Console.WriteLine(CalculateSum());
        }
    }
}
