using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Solution
    {
        static double positiveNumbers;
        static double negativeNumbers;
        static double zeroes;

        static void CountNumbers(string[] entries)
        {
            positiveNumbers = 0;
            negativeNumbers = 0;
            zeroes = 0;
            int[] numbersFromEntries = Array.ConvertAll(entries, Int32.Parse);

            for (int i = 0; i < numbersFromEntries.Length; i++)
            {
                if (numbersFromEntries[i] > 0)
                {
                    positiveNumbers++;
                }
                else if (numbersFromEntries[i] < 0)
                {
                    negativeNumbers++;
                }
                else
                {
                    zeroes++;
                }
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            CountNumbers(numbers);

            Console.WriteLine(positiveNumbers / n);
            Console.WriteLine(negativeNumbers / n);
            Console.WriteLine(zeroes / n);
            Console.ReadKey();
        }
    }
}
