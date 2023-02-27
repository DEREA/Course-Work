using System;
using System.Threading;
namespace ITEHA_Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread mainThread = Thread.CurrentThread;

          //  Console.WriteLine("Hello World!");

            Thread Thread1 = new Thread(Th1);
            Thread1.Name = "Thread1";

            Thread Thread2 = new Thread(Th2);
            Thread2.Name = "Thread2";

            Thread Thread3 = new Thread(Th3);
            Thread3.Name = "Thread3";

            Thread1.Start();
            Thread2.Start();
            Thread3.Start();

        }


        public static void Th1() 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread 1: Eduvos");
            }
        }

        public static void Th2()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Thread 2: Education");
            }
        }

        public static void Th3()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Thread 3: Schools");
            }
        }



    }
}
