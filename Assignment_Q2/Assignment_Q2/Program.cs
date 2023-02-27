using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = new int[6];
            int[] arr2 = new int[4];

            int count = 0;

            for (int i = 0; i <= 999999; i++)
            {

                int num = 0;
                Console.WriteLine("Insert number " + (count + 1));
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {

                }

                if (num != 0 && num > 0 && num % 2 == 0 && num <= 12)
                {
                    arr1[count] = num;
                    count++;

                    if (count == 6)
                    {
                        break;
                    }

                }

            }


            Console.WriteLine("");
            Console.WriteLine("Array 1:");
            Console.WriteLine("");

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("" + arr1[i]);
            }

            Console.WriteLine("");

            count = 0;

            for (int i = 0; i <= 999999; i++)
            {

                int num = 0;
                Console.WriteLine("Insert number " + (count + 1));
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {

                }

                if (num != 0 && num > 0 && num % 2 == 1 && num >= 20 && num <= 40)
                {
                    arr2[count] = num;
                    count++;

                    if (count == 4)
                    {
                        break;
                    }

                }

            }

            Console.WriteLine("");
            Console.WriteLine("Array 2:");
            Console.WriteLine("");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("" + arr2[i]);
            }

           


            Console.WriteLine("");
            Console.WriteLine("Merged Array Unsorted:");
            Console.WriteLine("");

            arr1 = arr1.Concat(arr2).ToArray();


            int[] unsortedArr = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                unsortedArr[i] = arr1[i];
                
            }



            foreach (var e in arr1)
            {
                Console.WriteLine(e);
            }


            int[] bubbleSort = BubbleSort(arr1);

            


            Console.WriteLine("");
            Console.WriteLine("Bubble Sorted:");
            Console.WriteLine("");

            for (int i = 0; i < bubbleSort.Length; i++)
            {
                Console.WriteLine("" + bubbleSort[i]);
            }



            Console.WriteLine("");
            Console.WriteLine("Before Selection Sort:");
            Console.WriteLine("");

            foreach (var e in unsortedArr)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("");
            Console.WriteLine("Selection Sorted:");
            Console.WriteLine("");

            Stack<int> stck = new Stack<int>(unsortedArr);

            stck = sortstackAsc(stck);

            foreach (var e in stck)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("");
            Console.WriteLine("Linked List: ");
            Console.WriteLine("");

            LinkedList<int> lnkLst = new LinkedList<int>(unsortedArr);
            lnkLst.AddLast(31);
            foreach (var e in lnkLst)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("");
            int[] midNum = new int[lnkLst.Count];
            lnkLst.CopyTo(midNum,0);

            int placeholder = 0;

            for (int i=0;i<=midNum.Length/2;i++) 
            {
                placeholder = midNum[i];
            }

            Console.WriteLine("The middle number is:"+placeholder);
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Linked list in reverse order");
            Console.WriteLine("");

            lnkLst.Reverse();

            foreach (var e in lnkLst)
            {
                Console.WriteLine(e);
            }


           
            lnkLst.AddLast(45);

            Console.WriteLine("");
            Console.WriteLine("Added 45 to the linked list");
            Console.WriteLine("");

            foreach (var e in lnkLst)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("");
            Console.WriteLine("Size = " + lnkLst.Count);
            Console.WriteLine("");



            Console.WriteLine("");
            Console.WriteLine("Removed 31");
            Console.WriteLine("");

            var node = lnkLst.First;
            while (node != null)
            {
                var nextNode = node.Next;
                if (node.Value == 31)
                {
                    lnkLst.Remove(node);
                }
                node = nextNode;
            }


                foreach (var e in lnkLst)
            {
                Console.WriteLine(e);
            }

            int index = 5;
          // Node<int> currentNode = lnkLst.First;
            /*
            for (int i=0;i<lnkLst.Count;i++) 
            {
                if (i!=index) 
                {
                    lnkLst.
                }
            }
            */

            Console.ReadLine();

        }






       public static int getMiddle(LinkedList<int> lnkLst) 
        {
            Node head = new Node(1);
            Node fast =head;
            Node slow = head;

            if (head.next==null) 
            {
                return head.data;
            }

            if (head.next.next == null)
            {
                return head.data;
            }

            while (fast.next !=null) 
            {
                fast = fast.next;
                slow = slow.next;
                if (fast.next!=null) 
                {
                    fast = fast.next;
                }
            }

            return slow.data;
        }

        public class LinkedList
        {
         public Node head;
            private Node Last;

            public void Add(int value)
            {
                Node oldLast = Last;

                Last = new Node(value);

                if (head == null)
                {
                    head = Last;
                }
                else
                {
                    oldLast.next = Last;
                }
            }
        }
        public class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        


        public static Stack<int> sortstackAsc(Stack<int> input)
        {
            Stack<int> tmpStack = new Stack<int>();
            while (input.Count > 0)
            {

                int tmp = input.Pop();


                while (tmpStack.Count > 0 && tmpStack.Peek() < tmp)
                {

                    input.Push(tmpStack.Pop());
                }


                tmpStack.Push(tmp);
            }
            return tmpStack;
        }




        public static int[] BubbleSort(int[] arr)
        {
            int sub;

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        sub = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = sub;
                    }
                }
                
            }
            return arr;
        }
    }
}
