using System;
using System.Numerics;

namespace Fibonacci_Modified
{
    class Solution
    {
        public static BigInteger BigT1;
        public static BigInteger BigT2;
        public static BigInteger temp;

        static BigInteger FibonacciModified(int t1, int t2, int n)
        {
            BigT1 = new BigInteger(t1);
            BigT2 = new BigInteger(t2);
            temp = new BigInteger(0);

            for (int i = 3; i <= n; i++)
            {
                temp = BigT2;
                BigT2 = BigInteger.Add(BigT1, BigInteger.Pow(BigT2, 2));
                BigT1 = temp;
            }
            return BigT2;
        }

        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int t1 = Convert.ToInt32(inputNumbers[0]);
            int t2 = Convert.ToInt32(inputNumbers[1]);
            int n = Convert.ToInt32(inputNumbers[2]);

            Console.WriteLine(FibonacciModified(t1, t2, n));
            Console.ReadKey();
        }
    }
}
