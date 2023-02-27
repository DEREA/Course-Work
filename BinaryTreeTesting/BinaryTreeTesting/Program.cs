using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Val = new int[] { 22, 10, 3, 7, 15, 6, 2 };

            Tree BTree = new Tree(Val);


            Console.WriteLine("BTree values:");

            Console.WriteLine(BTree);


            Console.WriteLine("Tree Depth:");
            Console.WriteLine(Convert.ToString(BTree.GetTreeDepth()));

            Console.WriteLine("PreOrder Traversal:");
            BTree.TraversePreOrder(BTree.root);
            Console.WriteLine();
            Console.ReadLine();


        }

        public class node
        {
            public node leftNode { get; set; }
            public node rightNode { get; set; }
            public int Data { get; set; }


        }


        public class Tree
        {
            public node root { get; set; }

          


            public int GetTreeDepth()
            {
                return this.GetTreeDepth(this.root);
            }

            private int MinValue(node node)
            {
                int minv = node.Data;

                while (node.leftNode != null)
                {
                    minv = node.leftNode.Data;
                    node = node.leftNode;
                }

                return minv;
            }


            int[] TreeArray;

            public Tree(int[] val)
            {
                this.TreeArray = val;
            }

            public override string ToString()
            {
                string xd = "";

                for (int i = 0; i < this.TreeArray.Length; i++)
                {
                    xd = xd + TreeArray[i] + ",";
                }

                return xd;
            }

            private int GetTreeDepth(node parent)
            {
                return parent == null ? 0 : Math.Max(GetTreeDepth(parent.leftNode), GetTreeDepth(parent.rightNode)) + 1;
            }

            public void TraverseInOrder(node parent)
            {
                if (parent != null)
                {

                    TraverseInOrder(parent.leftNode);
                    Console.Write(parent.Data + " ");
                    TraverseInOrder(parent.rightNode);

                }

            }

            public void TraversePreOrder(node parent)
            {
                if (parent != null)
                {
                    Console.Write(parent.Data + " ");
                    TraversePreOrder(parent.leftNode);
                    TraversePreOrder(parent.rightNode);
                }
            }




        }
    }
}
