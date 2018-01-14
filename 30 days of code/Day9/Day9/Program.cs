using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            int n = Convert.ToInt32(Console.ReadLine());
            string checkForEntry;

            for (int i = 0; i < n; i++)
            {
                string[] dictionaryEntry = Console.ReadLine().Split(' ');
                dictionary.Add(dictionaryEntry[0], dictionaryEntry[1]);
            }

            while (true) {

                checkForEntry = Console.ReadLine();

                if (checkForEntry == null)
                {
                    break;
                }
                else
                {
                    if (dictionary.ContainsKey(checkForEntry))
                    {
                        Console.WriteLine(checkForEntry + "=" + dictionary[checkForEntry]);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
            } 

            Console.ReadKey();
        }
    }
}
