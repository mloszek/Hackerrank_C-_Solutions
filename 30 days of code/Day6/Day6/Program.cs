using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Solution
    {
        public Solution() {
        }

        int calculateResult(int a, int b) {

            return a * b;
        }

        void showFirstTenMultiplications(int n) {

            for (int i = 1; i < 11; i++) {
                Console.WriteLine(n + " x " + i + " = " + calculateResult(n, i));
            }


        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Solution sol = new Solution();

            sol.showFirstTenMultiplications(n);
            Console.ReadKey();
        }
    }
}
