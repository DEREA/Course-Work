using System;
using System.Collections.Generic;

namespace Test2Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> provinces = new List<string>();

            provinces.Add("Western Cape");
            provinces.Add("Eastern Cape");
            provinces.Add("Northern Cape");
            provinces.Add("North West");
            provinces.Add("Free State");
            provinces.Add("Kwazulu Natal");
            provinces.Add("Gauteng");
            provinces.Add("Limpopo");
            provinces.Add("Mpumalanga");

            provinces.Sort();
           
            provinces.ToArray();

            for (int i=0;i< provinces.Count;i++) 
            {
                Console.WriteLine(provinces[i]);
            }
            



        }
    }
}
