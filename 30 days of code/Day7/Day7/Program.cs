using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Solution
    {
        public Solution() { }

        void hackTheString(string word) {

            char[] hackedWord = word.ToCharArray();
            StringBuilder evenString = new StringBuilder();
            StringBuilder oddString = new StringBuilder();

            for (int i = 0; i < word.Length; i++) {

                if (i == 0 || i % 2 == 0)
                {
                    evenString.Append(hackedWord[i]);
                }
                else {
                    oddString.Append(hackedWord[i]);
                }
            }

            Console.WriteLine(evenString.ToString() + " " + oddString.ToString());
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Solution sol = new Solution();

            for (int i = 0; i < n; i++) {
                sol.hackTheString(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
