using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] BubbleArray = new int[] { 5, 1, 25, 7, 89, 56, 74, 85, 31, 3, 3, 4 };

            int[] arr = new int[] { 6,3,6,9,12,67,45,12,45,34,39 };
            Stack<int> InsertionSortdesc = new Stack<int>(arr);

            int[] arr2 = new int[] { 6, 3, 6, 9, 12, 67, 45, 12, 45, 34, 39 };
            Stack<int> InsertionSortasc = new Stack<int>(arr2);


            InsertionSortdesc = sortstackDesc(InsertionSortdesc);
            InsertionSortasc = sortstackAsc(InsertionSortasc);

            int[] arr3= new int[11];

            Random rand = new Random();
            for (int j = 1; j <= 10; j++) 
            {
                arr3[j] = rand.Next(1,100);
            }

            /*
            for (int i = 0; i <= arr.Length - 2; i++) 
            {
                Console.Write(""+arr3[i]+"," );
            }
            */


                LinkedList<int> SelectionSort = new LinkedList<int>(arr3);

            arr3 = Sort(arr3);
           
           

            ///////BubbleSort

            BubbleArray = BubbleSort(BubbleArray);
            Console.Write("BubbleSort:");
            for (int i = 0; i <= BubbleArray.Length-1; i++) 
            {
                Console.Write(""+BubbleArray[i]+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("InsertionSort in desc:");
            /////InsertionSort

            while (InsertionSortdesc.Count > 0)
            {
                Console.Write(InsertionSortdesc.Pop() + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("InsertionSort in asc:");
            while (InsertionSortasc.Count > 0)
            {
                Console.Write(InsertionSortasc.Pop() + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("SelectionSort:");

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                Console.Write("" + arr3[i] + ",");
            }



            Console.ReadLine();
        }

        public static int[] BubbleSort(int[] arr)
        {
            int sub;

            for (int i=0;i<=arr.Length-2;i++) 
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {

                    if (arr[j] < arr[j + 1])
                    {
                        sub = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = sub;
                    }
                }

            }

            return arr;

        }

        public static Stack<int> sortstackDesc(Stack<int> input)
        {
            Stack<int> tmpStack = new Stack<int>();
            while (input.Count > 0)
            {
                
                int tmp = input.Pop();

               
                while (tmpStack.Count > 0 && tmpStack.Peek() > tmp)
                {
                    
                    input.Push(tmpStack.Pop());
                }

                
                tmpStack.Push(tmp);
            }
            return tmpStack;
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
       

        public static int[] Sort(int[] data)
        {
            Console.Write("\nSorted Array Elements :(Step by Step)\n\n");
          
            int smallest;
            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                        
                    }
                }
                Swap(i, smallest,data);
                
                
               
            }
            return data;
        }

        public static void Swap(int first, int second, int[] data)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }



    }
}
