using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Entry : IComparable<Entry>
    {
        public string FirstName { get; set; }
        public string EmailID { get; set; }

        public int CompareTo(Entry otherEntry)
        {
            
            return String.Compare(this.FirstName, otherEntry.FirstName);
        }
    }
}
