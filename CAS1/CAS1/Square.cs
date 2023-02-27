using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS1
{
    class Square
    {
        private int width = 0;
        

        public int getWidth() 
        {
            return width;
        }

        public void setWidth(int width) 
        {
            this.width=width;
        }

        public int CalculateArea() {

            return width*width;
        }


        public override string ToString()
        {
            String xd = "Width: "+width+"";
            return xd;
        }



    }
}
