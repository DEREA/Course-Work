using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPCA_Exam_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a URL");
            //string url = Console.ReadLine();
            string url= "https://www.google.com/search?q=javatpoint&oq=javatpoint&sourceid=chrome&ie=UTF-8";



            Uri uri = new Uri(url);
            string requested = uri.Scheme + Uri.SchemeDelimiter + uri.Host + ":" + uri.Port;

            Console.WriteLine("Protocol:"+ requested);


            Uri myUri = new Uri(url);
            string host = myUri.Host;

            Console.WriteLine("Host Name:" + host);

        }
    }
}
