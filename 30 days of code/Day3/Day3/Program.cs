using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static int calculateTotalCost(double mealCost, int tipPercent, int taxPercent)
        {
            return Convert.ToInt32(mealCost + (mealCost * tipPercent / 100) + (mealCost * taxPercent / 100));
        }

        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The total meal cost is {0} dollars.", calculateTotalCost(mealCost, tipPercent, taxPercent));
            Console.ReadKey();
        }
    }
}
