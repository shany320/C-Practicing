using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_Assignment03.Part02
{
    class Circle : Icircle
    {
        public double radius { get; set; }
        public double Area { get { return Math.PI * radius * radius; } }
    }
    class Rectangle : Irectangle
    {
        public double length { get; set; }
        public double width { get; set; }
       
        public double Area => length*width;
    }
}
