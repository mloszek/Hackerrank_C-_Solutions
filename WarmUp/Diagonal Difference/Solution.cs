using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Solution
    {
        static int CountAbsoluteDiagonalDifference(int[][] matrix)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                leftDiagonal += matrix[i][i];
                rightDiagonal += matrix[i][matrix.Length - 1 - i];
            }

            return Math.Abs(leftDiagonal - rightDiagonal);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                matrix[i] = Array.ConvertAll(line, Int32.Parse);
            }
            Console.WriteLine(CountAbsoluteDiagonalDifference(matrix));
            Console.ReadKey();
        }
    }
}
