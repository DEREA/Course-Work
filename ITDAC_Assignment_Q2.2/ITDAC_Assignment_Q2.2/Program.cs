using System;

namespace ITDAC_Assignment_Q2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bubble sort \n \n");


            int[] intArr = { 72,90,78,82,68,73,85,93,87,65 };


            Console.WriteLine("Unsorted array: ");


            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i] + ", ");
            }


            Console.WriteLine("\n \n Ascending");


            int a;
            int b;
            int temp;

            for (int j = 0; j < intArr.Length - 1; j++)
            {

                for (int i = 0; i < intArr.Length - 1; i++)
                {
                    a = intArr[i];

                    b = intArr[i + 1];

                    if (b < a)
                    {
                        temp = a;
                        intArr[i] = b;
                        intArr[i + 1] = temp;
                    }

                }
            }

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i] + ", ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
