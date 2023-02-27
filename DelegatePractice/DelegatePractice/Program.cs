using System;

namespace DelegatePractice
{
    delegate void MyDelegate(string s, int i);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // MyDelegate messageDelegate =  = Console.WriteLine(name,12);
            MyDelegate del = new MyDelegate(AMethod);

            Console.WriteLine("Give a name");
            string name = Console.ReadLine();

            Console.WriteLine("Give a number");
            int num = Convert.ToInt32( Console.ReadLine());
            del(name,num);

        }
        static void AMethod(string name, int num)
        {
            Console.WriteLine("Name: "+name+" Num: "+num);
        }
    }
   
}
