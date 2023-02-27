using System;
using System.Collections;
namespace ITDCA_Assignment_Q3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentScores = new Hashtable();
          
            studentScores.Add("Tebogo",70);
            studentScores.Add("Mandla", 82);
            studentScores.Add("James", 66);
            studentScores.Add("Elain", 53);
            studentScores.Add("Mbali", 40);
            studentScores.Add("Clarissa", 96);
            studentScores.Add("Samson", 90);
            studentScores.Add("John", 64);
            studentScores.Add("Taylor", 45);
            studentScores.Add("Felix", 80);


            foreach (String k in studentScores.Keys) 
            {
                Console.WriteLine(k);
                Console.WriteLine(studentScores[k]);
                Console.WriteLine("");
            }



        }
    }
}
