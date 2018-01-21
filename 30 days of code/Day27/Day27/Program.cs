using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27
{
    class Solution
    {

        static int CalculateDaysFromMonths(int currentMonth)
        {

            var sum = 0;

            for (int i = 1; i < currentMonth; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    sum += 31;
                }
                else if (i == 2)
                {
                    sum += 28;
                }
                else
                {
                    sum += 30;
                }
            }

            return sum;
        }

        static int CountDays(int[] date)
        {

            var sum = 0;

            sum += date[2] * 365;
            sum += date[0];
            if (date[1] > 1)
            {
                sum += CalculateDaysFromMonths(date[1]);
            }

            return sum;
        }

        static int CalculateFine(int[] returnDate, int[] expectedDate)
        {

            var daysLate = CountDays(returnDate) - CountDays(expectedDate);

            if (daysLate <= 0)
            {
                return 0;
            }
            else if (returnDate[1] == expectedDate[1] && returnDate[2] == expectedDate[2])
            {
                return daysLate * 15;
            }
            else if (returnDate[1] > expectedDate[1] && returnDate[2] == expectedDate[2])
            {
                return 500 * (returnDate[1] - expectedDate[1]);
            }
            else if (returnDate[2] > expectedDate[2])
            {
                return 10000;
            }
            else
            {
                throw new Exception("Something went wrong...");
            }
        }

        static void Main(string[] args)
        {
            string[] firstDate = Console.ReadLine().Split(' ');
            string[] secondDate = Console.ReadLine().Split(' ');

            int[] returnDate = Array.ConvertAll(firstDate, int.Parse);
            int[] expectedDate = Array.ConvertAll(secondDate, int.Parse);

            Console.WriteLine(CalculateFine(returnDate, expectedDate));
            Console.ReadKey();
        }
    }
}
