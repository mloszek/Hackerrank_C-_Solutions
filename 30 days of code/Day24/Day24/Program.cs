using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
     unfinished
     
     */
namespace Day24
{
    
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Solution
    {
        static bool isRoot = true;

        static void levelOrder(Node root)
        {
            if (isRoot)
            {
                Console.Write("{0} ", root.data);
                isRoot = false;
            }

            if (root.left != null) {
                Console.Write("{0} ", root.left.data);
            }

            if (root.right != null)
            {
                Console.Write("{0} ", root.right.data);
            }

            if (root.left != null)
            {
                levelOrder(root.left);
            }

            if (root.right != null)
            {
                levelOrder(root.right);
            }


        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }
    }
}
