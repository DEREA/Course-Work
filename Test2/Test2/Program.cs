using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           // int a, b, c, d;

           // Random rnd = new Random();

           // a = rnd.Next(1, 10);
           // b = rnd.Next(1, 10);
           // c = rnd.Next(1, 10);
           // d = rnd.Next(1, 10);

           //int ans = a + b + c + d;

            for (int a =0;a<10;a++) 
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {


                            if ((a + b) / 2 > 2 &&(c + d) / 2 > 2)
                            {

                                Console.WriteLine((a+b)+""+(c+d));

                            }
                           // ans = ans + 1;
                           // d = d + 1;

                        }
                       // c = c + 1;

                    }
                   // b = b + 1;

                }
              //  a = a + 1;

            }


        }
    }
}
