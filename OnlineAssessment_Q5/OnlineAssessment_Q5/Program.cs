using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace OnlineAssessment_Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable numberNames = new Hashtable();
            numberNames.Add("Bem", 12); 
            numberNames.Add("Chloe", 5);
            numberNames.Add("Jane", 23);
            numberNames.Add("Den", 45);
            numberNames.Add("Mike", 90);

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);


            string[] name =new string[] {"Bem","Chloe","Jane", "Den","Mike" };
            int[] age =new int[] { 12,5,23,45,90};

            string nm;
            int ge;

            for (int i=0;i<age.Length-1;i++)
            {
                nm = name[i];
                ge = age[i];
                Console.WriteLine(sumAscii(nm,ge));
            }


            try
            {
                numberNames.Add("12", "Bem");
                numberNames.Add("5", "Chole");
                numberNames.Add("23", "Jane");
                numberNames.Add("45", "Den");
                numberNames.Add("90", "Mike");
            }
            catch (Exception e)
            {
                Console.WriteLine("This student is already in the list");
            }


            if (numberNames.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                Console.WriteLine("This student name isnt in the list");
            }



          
            ICollection key = numberNames.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + numberNames[k]);
            }
            Console.ReadKey();

            Console.ReadLine();

        }


        
 

            // Function that returns true
            // if n is prime
            static bool isPrime(int n)
            {
                if (n == 0 || n == 1)
                {
                    return false;
                }

                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            // Function to return the sum
            // of the ascii values of the characters
            // which are present at prime positions
           public static int sumAscii(string str, int n)
            {
                // To store the sum
                int sum = 0;

                // For every character
                for (int i = 0; i < n; i++)
                {

                    // If current position is prime
                    // then add the ASCII value of the
                    // character at the current position
                    if (isPrime(i + 1))
                    {
                        sum += (int)(str[i]);
                    }
                }

                return sum;
            }

            // Driver code
            public static void Main()
            {
                string str = "geeksforgeeks";
                int n = str.Length;

                Console.WriteLine(sumAscii(str, n));
            }
        }


    }
}
