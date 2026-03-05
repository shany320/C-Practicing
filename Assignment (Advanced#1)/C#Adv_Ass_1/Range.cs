using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Adv_Ass_1
{
    class Range<T> where T:IComparable,IConvertible
    {
        public T max { get; set; }
        public T min { get; set; }
        public Range(T _max, T _min)
        {
            max = _max;
            min =_min;
        }
        public bool Isinrange(T value) 
        {
            if (min.CompareTo(value) < 0 && max.CompareTo(value) > 0) 
            {
                Console.WriteLine("The Value you entered is in within range!");
                return true; 
            }
            else 
            {
                Console.WriteLine("The Value You entered is not within range!");
                return false;
            }
        }

        public double length() 
        {
            return Convert.ToDouble(max) - Convert.ToDouble(min);
        }
        
    }
}
