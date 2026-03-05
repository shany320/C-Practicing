using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP.Third_Project
{
    class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int S) 
        {
            Hours = S / 3600;
            Minutes = (S%3600)/60;
            Seconds= S%60;
        }
        public Duration (int H, int M, int S) 
        {
            Hours = H;
            Minutes = M;
            Seconds = S;
        }
        public override string ToString()
        {
            return $"Hours:{Hours}, Minutes:{Minutes}, Second:{Seconds}";
        }
        #region operators overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int total1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int total2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(Math.Max(0, total1 - total2));
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1 == d2;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1 == d2;
        }

        public static bool operator ==(Duration d1, Duration d2)
        {
            return d1.Equals(d2);
        }

        public static bool operator !=(Duration d1, Duration d2)
        {
            return !d1.Equals(d2);
        }
        public static bool operator true(Duration d)
        {
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
        }

        public static bool operator false(Duration d)
        {
            return !(d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0);
        }


        // Explicit conversion to DateTime
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
        #endregion


    }
}
