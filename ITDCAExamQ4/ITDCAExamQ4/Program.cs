using System;

namespace ITDCAExamQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(30);

            tree.root.left = new Node(20);
            tree.root.right = new Node(65);

            tree.root.left.left = new Node(15);
            tree.root.left.left.left = new Node(13);
            tree.root.left.right.right = new Node(25);


            tree.root.right.left = new Node(55);
            tree.root.right.right = new Node(70);



            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
            }



        }


        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        public class BinaryTree
        {
            public Node root;

            /*Given a binary tree, print out all of its root-to-leaf
              paths, one per line. Uses a recursive helper to do 
              the work.*/
            public virtual void printPaths(Node node)
            {
                int[] path = new int[1000];
                printPathsRecur(node, path, 0);
            }

            /* Recursive helper function -- given a node, and an array
               containing the path from the root node up to but not 
               including this node, print out all the root-leaf paths.*/
            public virtual void printPathsRecur(Node node, int[] path, int pathLen)
            {
                if (node == null)
                {
                    return;
                }

                /* append this node to the path array */
                path[pathLen] = node.data;
                pathLen++;

                /* it's a leaf, so print the path that lead to here  */
                if (node.left == null && node.right == null)
                {
                    printArray(path, pathLen);
                }
                else
                {
                    /* otherwise try both subtrees */
                    printPathsRecur(node.left, path, pathLen);
                    printPathsRecur(node.right, path, pathLen);
                }
            }

            /* Utility function that prints out an array on a line. */
            
            public virtual void printArray(int[] ints, int len)
            {
                int i;
                for (i = 0; i < len; i++)
                {
                    Console.Write(ints[i] + " ");
                }
                Console.WriteLine("");
            }




        }
    }
}
