using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ITDCA_Assignmnet_Q1._3
{
    class Program
    {
        static void Main(string[] args)
        {


            BinarySearchTree nums = new BinarySearchTree();
            nums.Insert(30);
            nums.Insert(20);
            nums.Insert(65);
            nums.Insert(70);
            nums.Insert(15);
            nums.Insert(55);
            nums.Insert(13);
            nums.Insert(80);
            nums.Insert(25);
            nums.Insert(72);


            Console.WriteLine("Finished Inserting values");


        }

        public class BinarySearchTree
        {

            public class Node
            {
                public int Data;
                public Node Left;
                public Node Right;
               
                public void DisplayNode()
                {

                    Console.Write(Data + " ");

                }
            }
           
            public Node root;
           
            public BinarySearchTree()
            {

                root = null;

            }
            public void Insert(int i)
            {
                Node newNode = new Node();
                
                newNode.Data = i;
                
                if (root == null)
                   
                    root = newNode;
               
                else
                {
                    Node current = root;
                   
                    Node parent;
                    
                    while (true)
                    {
                        parent = current;
                        if (i < current.Data)
                        {
                            current = current.Left;
                           
                            if (current == null)
                            {

                                parent.Left = newNode;
                                break;
                            }
                        }
                        else
                        {
                            current = current.Right;
                            
                            if (current == null)
                            {

                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }



        }
    }
}