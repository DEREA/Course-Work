using System;

namespace PreTestClassQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            guitar myguitar = new guitar();
           
           Console.WriteLine(myguitar.Play());
            Console.WriteLine(myguitar);
        }
    }
}
