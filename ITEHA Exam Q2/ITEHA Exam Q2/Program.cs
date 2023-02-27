using System;
using System.Threading;
namespace ITEHA_Exam_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating child thread");

            Thread Main = new Thread(StartTimer);
            Main.Start();
            
        }


        public static void StartTimer() 
        {
            Console.WriteLine("Child thread starts");
            Console.WriteLine("Child Thread opaused for 5 seconds");

            Thread.Sleep(5000);

            Console.WriteLine("Child thread resumes");

        }


    }
}
