using System;

namespace ITDCAExamQ2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arrlst = {56,85,42,73,65,30,90,75 };


            for (int i = 0; i < arrlst.Length; i++)
            {
               Console.Write(arrlst[i]+",");
            }

            Console.WriteLine();
            Console.WriteLine();


            int arrElements = 0;

            for (int i = 1; i <= arrlst.Length; i++)
            {
                arrElements = i;
            }

            Console.Write("There are " + arrElements + " elements in the array");

            Console.WriteLine();
            Console.WriteLine();


            int searchNum = 30;
            Boolean contains = false;

            for (int i = 0; i < arrlst.Length; i++)
            {
                if (arrlst[i]==searchNum) 
                {
                    contains = true;
                }
            }

            if (contains==true)
            {
                Console.Write("The array contains the number "+searchNum);
            }

            else 
            {
                Console.Write("The array does not contain the number "+searchNum);
            }

            Console.WriteLine();
            Console.WriteLine();


            searchNum = 30;
            contains = false;

            for (int i = 0; i < arrlst.Length; i++)
            {
                if (arrlst[i] == searchNum)
                {
                    contains = true;
                }
            }

            if (contains == true)
            {
                Console.Write("The array contains the number " + searchNum);
            }

            else
            {
                Console.Write("The array does not contain the number " + searchNum);
            }

            Console.WriteLine();
            Console.WriteLine();



            for (int i = 0; i < arrlst.Length; i++)
            {

                if (arrlst[i]!=90) 
                {
                    Console.Write(arrlst[i]+",");
                }


            }

            
        }
    }
}
