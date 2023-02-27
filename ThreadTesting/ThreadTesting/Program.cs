using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTesting
{
    class Program
    {
        static void Main(string[] args)
        {


            Thread thread1 = new Thread(new ThreadStart(Calc1));
            Thread thread2 = new Thread(new ThreadStart(Calc2));
            Thread thread3 = new Thread(new ThreadStart(Calc3));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            

        }

        static void Calc1() 
        {
            int num = 500;
            num = num + 100;
            Thread.Sleep(200);
            Console.WriteLine(num);
            
        }

        static void Calc2()
        {
            int num = 500;
            num = num - 100;
            Thread.Sleep(400);
            Console.WriteLine(num);
            
        }

        static void Calc3()
        {
            int num = 500;
            Thread.Sleep(56);
            Console.WriteLine(num);
            
        }





    }
}
