using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Val = new int[] { 61,101,81,11,41,2,21,36,51,81,71,121,111,91 };

            Tree BTree = new Tree(Val);

           

            BTree.Add(61);
            BTree.Add(101);
            BTree.Add(81);
            BTree.Add(11);
            BTree.Add(41);
            BTree.Add(2);
            BTree.Add(21);
            BTree.Add(36);
            BTree.Add(51);
            BTree.Add(81);
            BTree.Add(71);
            BTree.Add(121);
            BTree.Add(111);
            BTree.Add(91);


            Console.WriteLine("PreOrder Traversal");
            BTree.TraversePreOrder(BTree.root,BTree);
            Console.WriteLine("");

            Console.WriteLine("PostOrder Traversal");
            BTree.TraversePostOrder(BTree.root,BTree);
            Console.WriteLine("");

            Console.WriteLine("InOrder Traversal");
            BTree.TraverseInOrder(BTree.root,BTree);
            Console.WriteLine("");

            int find = 51;

            node node1 = BTree.Find(find, BTree.root);
            if (node1 == null)
            {
                Console.WriteLine("Searching for value "+find+": Not Found");
            }

            else 
            {
                Console.WriteLine("Searching for value " + node1.Data+": Found");
            }

            find = 55;

            node node2 = BTree.Find(find, BTree.root);
            if (node2 == null)
            {
                Console.WriteLine("Searching for value " + find + ": Not Found");
            }

            else
            {
                Console.WriteLine("Searching for value " + node2.Data + ": Found");
            }
            /*
             try
             {
                 node node = BTree.Find(22, BTree.root);
                 Console.WriteLine(node.Data);

             }
             catch (Exception e)
             { 
             }
            */

            node noed = BTree.Find(5,BTree.root);

            BTree.findeNodeLevel(11);
           

            Console.ReadLine();
           





        }
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


        public bool Add(int value)
        {
            node before = null, after = this.root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) 
                    after = after.leftNode;
                else if (value > after.Data) 
                    after = after.rightNode;
                else
                {
                    
                    return false;
                }
            }

            node newNode = new node();
            newNode.Data = value;

            if (this.root == null)//Tree is empty
                this.root = newNode;
            else
            {
                if (value < before.Data)
                    before.leftNode = newNode;
                else
                    before.rightNode = newNode;
            }

            return true;
        }








        public int findLevel(node node, int level, int key)
        {
            if (node == null)
            {
                return 0;
            }
            if (key == node.Data)
            {
                // When we get node
                return level;
            }
            // Reversibly, visit left
            var ans = this.findLevel(node.leftNode, level + 1, key);
            if (ans == 0)
            {
                // When result not found in left subtree
                // Reversibly, visit right
                ans = this.findLevel(node.rightNode, level + 1, key);
            }
            return ans;
        }




        public int findeNodeLevel(int key)
        {
            var ans=0;
            if (this.root == null)
            {
                //Console.WriteLine("\n Empty Tree");
                return ans;
            }
            // Find the level of given key node
            ans = this.findLevel(this.root, 1, key);
            if (ans != 0)
            {
               // Console.WriteLine("Node key " + key +
                 //                 " exist at level : " + ans);
                return ans;
            }
            else
            {
                // When node is not present
               // Console.WriteLine("Node key " + key + " not found ");
                return 0;
            }
        }



















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

        public int GetTreeDepth(node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.leftNode), GetTreeDepth(parent.rightNode)) + 1;
        }


        public node Find(int value, node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.leftNode);
                else
                    return Find(value, parent.rightNode);
            }

            return null;
        }

        public void TraverseInOrder(node parent,Tree Tr)
        {
            if (parent != null)
            {
                int ans = Tr.findeNodeLevel(parent.Data);

               
                TraverseInOrder(parent.leftNode,Tr);
                for (int i = 0; i <= ans - 1; i++)
                {
                    Console.Write("-");
                }
                Console.Write(parent.Data + " ");
                Console.WriteLine("");
                TraverseInOrder(parent.rightNode,Tr);

            }

        }

        public void TraversePreOrder(node parent,Tree Tr)
        {
            if (parent != null)
            {
                int ans=Tr.findeNodeLevel(parent.Data);

                for (int i=0;i<=ans-1;i++) 
                {
                    Console.Write("-");
                }

                Console.Write(parent.Data + "");
                Console.WriteLine("");
                TraversePreOrder(parent.leftNode,Tr);
                TraversePreOrder(parent.rightNode,Tr);
            }
        }

        public void TraversePostOrder(node parent,Tree Tr)
        {
            if (parent != null)
            {
                int ans = Tr.findeNodeLevel(parent.Data);

               
                TraversePostOrder(parent.leftNode,Tr);
                TraversePostOrder(parent.rightNode,Tr);
                for (int i = 0; i <= ans - 1; i++)
                {
                    Console.Write("-");
                }
                Console.Write(parent.Data + "");
                Console.WriteLine("");
            }
        }


    }
}
