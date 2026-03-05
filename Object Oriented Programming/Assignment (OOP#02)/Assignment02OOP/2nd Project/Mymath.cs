using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP._2nd_Project
{
    class Mymath
    {
        public static double add(double a , double b) 
        {
            return a + b;
        }
        public static double subtract(double a, double b)
        {
            return a - b;
        }
        public static double multiply(double a, double b) 
        {
            return a * b;
        }
        public static double divide(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }
    }
}
