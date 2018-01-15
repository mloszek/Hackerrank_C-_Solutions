using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    class Solution
    {
        public int result = 0;

        public void CheckIfNumberIsBiggerThanResult(int a, int b) {

            if (a > b)
            {
                result = a;
            }
        }

        public string ConvertToBinary(int n) {

            return Convert.ToString(n, 2);
        }

        public int MaxConsecutiveOnes(string binaryNumber)
        {
            var temp = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == 49)
                {
                    temp++;
                }
                else {
                    CheckIfNumberIsBiggerThanResult(temp, result);
                    temp = 0;
                }
            }
            CheckIfNumberIsBiggerThanResult(temp, result);

            return result;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Solution sol = new Solution();
            Console.WriteLine(sol.MaxConsecutiveOnes(sol.ConvertToBinary(n)));

            Console.ReadKey();
        }
    }
}
