using System;

namespace ITDCAExamQ3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = {9,7,4,10,2 };

            for (int i = 0; i < arr.Length-1; i++)
            {

                int min = i;

                for (int j = i+1; j < arr.Length; j++)
                {

                    if (arr[j]<arr[min]) 
                    {
                        min = j;

                        int tmp = arr[min];
                        arr[min] = arr[i];
                        arr[i] = tmp;



                    }



                }



            }

            /*
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }
            */


            int[] arr2 = { 9, 7, 4, 10, 2 };



            for (int i = 1; i < arr2.Length; i++)
            {

                int num1 = arr2[i];

                int num2 = i - 1;

                while (num2>=0 && arr2[i] > num1) 
                {
                    arr2[num2 + 1] = arr2[num2];
                    num2 = num2 - 1;
                    arr2[num2 + 1] = num2;
                }

                

            }



            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + ",");
            }








        }
    }
}
