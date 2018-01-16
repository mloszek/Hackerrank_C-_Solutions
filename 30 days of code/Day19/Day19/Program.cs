using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    class Solution
    {
        public Stack<char> stack = new Stack<char>();
        public Queue<char> queue = new Queue<char>();

        public void pushCharacter(char c)
        {
            stack.Push(c);
        }

        public void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        public char popCharacter()
        {
            return stack.Pop();
        }

        public char dequeueCharacter()
        {
            return queue.Dequeue();
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            Solution obj = new Solution();

            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
