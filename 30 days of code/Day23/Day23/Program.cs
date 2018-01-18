using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23
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
        
        static int getHeight(Node root)
        {
            var leftHeight = 0;
            var rightHeight = 0;

            if (root.left == null && root.right == null) {
                return 0;
            }

            if (root.left != null) {
                leftHeight++;
                leftHeight += getHeight(root.left);
            }

            if (root.right != null)
            {
                rightHeight++;
                rightHeight += getHeight(root.right);
            }

            return leftHeight > rightHeight ? leftHeight : rightHeight;
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

        static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }
    }
}
