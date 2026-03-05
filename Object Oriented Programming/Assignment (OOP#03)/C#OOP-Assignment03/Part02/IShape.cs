using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_Assignment03.Part02
{
    public interface IShape
    {
        public double Area { get;}
        public void display_shape_info() 
        { Console.WriteLine($"The area of the shape:{Area}"); }
    }
    public interface Icircle: IShape
    {
        public double radius { get ; set; }
    }
    public interface Irectangle: IShape
    {
        public double length { get; set; }
        public double width { get; set; }
    }
}
