using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{
    class Solution
    {
        static List<long> CalculateMinMaxSum(long[] numbers)
        {
            List<long> temp = new List<long>();

            for (int i = 0; i < numbers.Length; i++)
            {
                temp.Add(numbers.Sum() - numbers[i]);
            }
            return temp;
        }

        static void Main(string[] args)
        {
            string[] entries = Console.ReadLine().Split(' ');
            long[] numbers = Array.ConvertAll(entries, Int64.Parse);

            List<long> results = CalculateMinMaxSum(numbers);
            results.Sort();
            Console.WriteLine($"{results[0]} {results[results.Count - 1]}");
            Console.ReadKey();
        }
    }
}
