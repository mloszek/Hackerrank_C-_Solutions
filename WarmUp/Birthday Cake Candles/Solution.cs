using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Solution
    {
        static long FindHighestCandle(long[] numbers)
        {
            Array.Sort(numbers);
            return numbers[numbers.Length - 1];
        }

        static int HowManyCandlesBlown(long[] numbers, long highestCandle)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == highestCandle)
                {
                    result++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] entries = Console.ReadLine().Split(' ');
            long[] numbers = Array.ConvertAll(entries, Int64.Parse);
            long highestCandle = FindHighestCandle(numbers);
            int result = HowManyCandlesBlown(numbers, highestCandle);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
