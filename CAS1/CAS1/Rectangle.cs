using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS1
{
    class Rectangle
    {
        private int width = 0;
        private int height = 0;

        public int getWidth()
        {
            return width;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }


        public int getHeight()
        {
            return height;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }


        public int CalculateArea()
        {

            return width * height;
        }


        public override string ToString()
        {
            String xd = "Width: " + width + "";
            return xd;
        }

    }
}
