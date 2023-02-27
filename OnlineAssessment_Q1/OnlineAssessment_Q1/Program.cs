using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OnlineAssessment_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] fixedArr = new int[6];

            fixedArr[0] = 6;
            fixedArr[1] = 20;
            fixedArr[2] = 75;
            fixedArr[3] = 96;
            fixedArr[4] = 112;
            fixedArr[5] = 119;


            ArrayList arrlst1 = new ArrayList(fixedArr);


            arrlst1.Add(0);
            arrlst1.Add(0);
            arrlst1.Add(0);
            arrlst1.Add(0);
            arrlst1.Add(0);

            Console.WriteLine("1.1 fixed arr");

            foreach (var val in fixedArr)
                Console.WriteLine(val);


            arrlst1.Insert(2, 45);


            Console.WriteLine("1.2 dynamic arr");

            foreach (var val in arrlst1)
                Console.WriteLine(val);

         


            Console.ReadLine();

        }
    }
}
