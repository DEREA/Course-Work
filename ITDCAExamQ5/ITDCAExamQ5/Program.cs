using System;

namespace ITDCAExamQ5
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr = { 50, 33, 78, -23, 90, 95 };

            Console.WriteLine("Unsorted");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }


            Console.WriteLine();
            Console.WriteLine("Sorted");


            int a;
            int b;
            int temp;

            for (int j = 0; j < arr.Length - 1; j++)
            {

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    a = arr[i];

                    b = arr[i + 1];

                    if (b < a)
                    {
                        temp = a;
                        arr[i] = b;
                        arr[i + 1] = temp;
                    }





                }


               
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("\n\n");


        }
    }
    
}
        
