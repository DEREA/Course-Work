using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many rows?");
            int rownum;
            int n = 1;

            
            rownum = Convert.ToInt32(Console.ReadLine());
            
            
            
            for (int i = 0; i < rownum; i++)
            {
                
                for (int j = 1; j <= rownum - i; j++)
                { 
                    Console.Write("  ");

                }
                for (int k = 0; k <= i; k++)
                {
                    if (k == 0 || i == 0)
                    {
                        n = 1;
                    }

                    else
                    {
                        n = n * (i - k + 1) / k;
                    }
                        
                    Console.Write(n+"   ");
                    
                }
                Console.Write("\n");


            }
        
        }
    }
}
