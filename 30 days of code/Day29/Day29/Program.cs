using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29
{
    class Entry : IComparable<Entry>
    {
        public string FirstName { get; set; }
        public string EmailID { get; set; }

        public int CompareTo(Entry otherEntry)
        {

            return String.Compare(this.FirstName, otherEntry.FirstName);
        }
    }

    class Solution
    {
        static void DeleteNonGmailAccounts(List<Entry> list)
        {
            string domain;

            for (int i = 0; i < list.Count(); i++)
            {
                domain = list[i].EmailID.Split('@')[1];

                if (domain != "gmail.com")
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<Entry> list = new List<Entry>();

            for (int a0 = 0; a0 < N; a0++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                list.Add(new Entry() { FirstName = tokens_firstName[0], EmailID = tokens_firstName[1] });
            }

            DeleteNonGmailAccounts(list);
            list.Sort();

            foreach (Entry e in list)
            {
                Console.WriteLine(e.FirstName);
            }
            Console.ReadKey();
        }
    }
}
