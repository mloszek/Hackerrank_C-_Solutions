using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Solution
    {
        static int[][] arr = new int[6][];
        int result = 0;

        void CheckIfSumIsBiggerThanResult(int n)
        {

            if (n > result)
            {
                result = n;
            }
        }

        int LargestSumFromHourglass()
        {

            var temp = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp = SumOfThisHourglass(i, j);
                    if (i == 0 && j == 0)
                    {
                        result = temp;
                    }
                    else
                    {
                        CheckIfSumIsBiggerThanResult(temp);
                    }
                }
            }

            return result;
        }

        int SumOfThisHourglass(int i, int j)
        {

            var sum = 0;

            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 3; m++)
                {
                    if (k != 1)
                    {
                        sum += arr[i + k][j + m];
                    }
                    else if (m != 0 && m != 2)
                    {
                        sum += arr[i + k][j + m];
                    }
                }
            }

            return sum;
        }


        static void Main(string[] args)
        {

            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            Solution sol = new Solution();
            Console.WriteLine(sol.LargestSumFromHourglass());
            Console.ReadKey();
        }
    }
}
