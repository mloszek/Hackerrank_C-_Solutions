using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    abstract class Book
    {

        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            this.title = t;
            this.author = a;
        }
        public abstract void display();
    }

    class MyBook : Book
    {
        private int price;

        public MyBook(string t, string a, int price) : base(t, a)
        {
            this.price = price;
        }

        public override void display()
        {

            Console.Write("Title: " + title + "\nAuthor: " + author + "\nPrice: " + price);
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
