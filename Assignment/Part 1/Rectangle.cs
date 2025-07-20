using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_1
{
    internal class Rectangle
    {
        public Rectangle()
        {
            Width = 0; Height = 0;
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(int num) : this(num, num)
        {

        }


        public int Width { get; set; }
        public int Height { get; set; }
    }
}

