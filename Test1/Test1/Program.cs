using System;
using System.Collections.Specialized;
using System.IO.IsolatedStorage;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me an amount of monkeys");
            int Monkeys = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            
            while (x != Monkeys)
            {

                if (x == 1)
                {
                    Console.WriteLine(x + " Monkey");
                }

                else if (x > 1)
                {
                    Console.WriteLine(x + " Monkeys");
                }
                System.Threading.Thread.Sleep(500);
                x++;
            }

            if (Monkeys >= 10) {
                Console.WriteLine("You have " + Monkeys + " Monkeys. That's a lot of monkeys");
            }
            else  {

                Console.WriteLine("You have " + Monkeys + " Monkeys. That's not so many monkeys");

            }

            
            Console.WriteLine("------------------------------- ");

            Console.WriteLine("How Many Students are there?");
            int numOfStudents = Convert.ToInt32(Console.ReadLine());


            String[] Students = new string[numOfStudents];

            for (int i = 0; i < numOfStudents; i++) {
                Console.WriteLine("What is the name of student "+(i+1));
                Students[i] = Console.ReadLine();


            }

            Console.WriteLine("------------------------------- ");
            Console.WriteLine("Listing all students in array ");

            for (int i=0; i<Students.Length; i++) {
                Console.WriteLine(Students[i]);
            }





        }
        }
    }

