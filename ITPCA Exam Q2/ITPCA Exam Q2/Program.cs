using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPCA_Exam_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieAgeRating = 15;
            int viewerAge = 10;

            //2.1 If statement
            // when the condition is met, the program will run the code within the If statement
            if (viewerAge>=movieAgeRating) 
            {
                Console.WriteLine("You are old enough to watch this movie");
            }


            //2.2 If-else
            // If the condition is met, the program will execute the contents of the if statement however, if the condition is not met, the program will execute the code within the else statement
            if (viewerAge >= movieAgeRating)
            {
                Console.WriteLine("You are old enough to watch this movie");
            }
            else 
            {
                Console.WriteLine("You are "+(movieAgeRating-viewerAge)+" year/s too young to watch this movie");
            }


        }
    }
}
