using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS1
{
    class Program
    {
        static void Main(string[] args)
        {

            Square newSQ = new Square();
            Console.WriteLine("Enter a width");
            newSQ.setWidth(Convert.ToInt32(Console.ReadLine()));

            // Console.WriteLine("" + Convert.ToString(newSQ.getWidth));
            Console.WriteLine("Square");
            Console.WriteLine("Width: "+newSQ.getWidth());
            Console.WriteLine("Area: "+newSQ.CalculateArea()); 
            

            Console.ReadLine();

            Rectangle newRT = new Rectangle();
            Console.WriteLine ("Enter a width");
            newRT.setWidth(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter a height");
            newRT.setHeight(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Rectangle");
            Console.WriteLine("Width: " + newRT.getWidth());
            Console.WriteLine("Height: " + newRT.getHeight());
            Console.WriteLine("Area: " + newRT.CalculateArea());


            Console.ReadLine();
        }
    }
}
