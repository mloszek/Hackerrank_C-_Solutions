using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int i, i2, iResult;
            double d, d2, dResult;
            string s, s2, sResult;

            i = 4;
            d = 4.0;
            s = "HackerRank ";

            i2 = int.Parse(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());
            s2 = Console.ReadLine();

            iResult = i + i2;
            dResult = d + d2;
            sResult = s + s2;

            Console.Write(iResult + "\n" + String.Format("{0:0.0}", dResult) + "\n" + sResult);
            Console.ReadKey();
        }
    }
}
