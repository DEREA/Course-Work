using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAssessment_Q2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> lnklst = new LinkedList<int>();

            lnklst.AddLast(119);
            lnklst.AddLast(220);
            lnklst.AddLast(300);
            lnklst.AddLast(415);

            Console.WriteLine("");
            Console.WriteLine("Linked List:");
            Console.WriteLine("");

            foreach (int element in lnklst)
            {
                Console.Write(element+", ");
            }

            Console.WriteLine("");
            Console.WriteLine("Stack:");
            Console.WriteLine("");

            Stack<int> stack = new Stack<int>(lnklst);
           stack.Reverse();
            


            foreach (int element in stack)
            {
                Console.Write(element + ", ");
            }


            Console.ReadLine();


        }

        class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        internal class SingleLinkedList
        {
             Node head;
        }


    }
}
