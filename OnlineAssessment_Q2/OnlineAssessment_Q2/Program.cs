using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAssessment_Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            //  string[] Fruits = new string[5];
            /*
              Fruits[0] = "Pawpaw";
              Fruits[1] = "Water Melon";
              Fruits[2] = "Apple";
              Fruits[3] = "Orange";
              Fruits[4] = "Strawberry";
            */


            Selection_Sort selection = new Selection_Sort(5);
            selection.Sort();


/*
            for (int i = 0; i < Fruits.Length - 1; i++)
            {
                Console.WriteLine(Fruits[i]);
            }
*/

            Console.ReadLine();

        }

        class Selection_Sort
        {
            private string[] data;

            //Create an array of 10 random numbers
            public Selection_Sort(int size)
            {
                data = new string[size];

                data[0] = "PawPaw";
                data[1] = "Water Melon";
                data[2] = "Apple";
                data[3] = "Orange";
                data[4] = "Strawberry";


            }

            public void Sort()
            {
                Console.Write("\nSorted Array Elements :(Step by Step)\n\n");
                display_array_elements();
                int smallest;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    smallest = i;

                    for (int index = i + 1; index < data.Length; index++)
                    {
                        if (data[index][0] < data[smallest][0])
                        {
                            smallest = index;
                        }
                    }
                    Swap(i, smallest);
                    display_array_elements();
                }

            }

            public void Swap(int first, int second)
            {
                string temporary = data[first];
                data[first] = data[second];
                data[second] = temporary;
            }

            public void display_array_elements()
            {
                foreach (var element in data)
                {
                    
                    Console.Write(element + ", ");
                }
                Console.Write("\n\n");
            }


        }
    }
}
