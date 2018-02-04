using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Solution
    {
        static string[] AlicesTriplet;
        static string[] BobsTriplet;
        static int AlicesPoints;
        static int BobsPoints;

        static void CompareTriplets()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Convert.ToInt32(AlicesTriplet[i]) > Convert.ToInt32(BobsTriplet[i]))
                {
                    AlicesPoints++;
                }
                else if (Convert.ToInt32(AlicesTriplet[i]) < Convert.ToInt32(BobsTriplet[i]))
                {
                    BobsPoints++;
                }
            }
        }

        static void Main(string[] args)
        {
            AlicesTriplet = Console.ReadLine().Split(' ');
            BobsTriplet = Console.ReadLine().Split(' ');
            AlicesPoints = 0;
            BobsPoints = 0;

            CompareTriplets();
            Console.WriteLine($"{AlicesPoints} {BobsPoints}");
            Console.ReadKey();
        }
    }
}
