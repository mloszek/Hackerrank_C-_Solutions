using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Array_Sum
{
    class Solution
    {
        static int SumOfEntries(string[] entries)
        {
            var result = 0;

            for (int i = 0; i < entries.Length; i++)
            {
                result += Convert.ToInt32(entries[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            string trash = Console.ReadLine();
            string[] numbers = Console.ReadLine().Split(' ');

            Console.WriteLine(SumOfEntries(numbers));
        }
    }
}
