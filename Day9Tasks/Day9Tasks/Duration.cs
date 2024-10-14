using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Tasks
{
    class Duration :IComparable<Duration>
    {
        public int Hourse { get; set; }
        public int Minute { get; set; }
        public int Seconds { get; set; }
        public Duration()
        {


            Hourse = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Seconds = DateTime.Now.Second;
        }

        public Duration(int hourse, int minute, int seconds)
        {
            if (hourse < 24)
            {
                Hourse = hourse;
            }
            else
            {
                Hourse = hourse % 24;
            }

            if (minute < 60)
            {
                Minute = minute;
            }
            else
            {
                Minute = minute % 60;
            }
            if (seconds < 60)
            {
                Seconds = seconds;
            }
            else
            {
                Seconds = seconds % 60;
            }
        }

        public Duration(int x)
        {
            int h, m, s;
            h = x / 3600;
            m = (x % 3600) / 60;
            s = (x % 60);

            Hourse = h;
            Minute = m;
            Seconds = s;

        }

        public override bool Equals(object? obj)
        {


            var right = obj as Duration;

            if (right is null) return false;

            if (object.ReferenceEquals(right, this)) { return true; }

            if (right.GetType() != this.GetType()) { return false; }

            return this.Hourse == right.Hourse && this.Minute == right.Minute && this.Seconds == right.Seconds;
        }

        public static Duration operator +(Duration a, Duration b)
        {
            int total = a.Hourse * 3600 + a.Minute * 60 + a.Seconds + b.Hourse * 3600 + b.Minute * 60 + b.Seconds;
            return new Duration(total);

        }

        public static Duration operator +(Duration a, int b)
        {
            int total = a.Hourse * 3600 + a.Minute * 60 + a.Seconds + b;
            return new Duration(total);

        }
        public static Duration operator +(int b, Duration a)
        {
            int total = a.Hourse * 3600 + a.Minute * 60 + a.Seconds + b;
            return new Duration(total);

        }
        public static Duration operator ++(Duration a)
        {

            // a.Hourse++;
            //a.Minute++;
            // a.Seconds++;




            return new Duration(a.Hourse, a.Minute + 1, a.Seconds);
        }
        public static Duration operator --(Duration a)
        {

            // a.Hourse--;
           // a.Minute--;
            //a.Seconds--;


            return new Duration(a.Hourse, a.Minute - 1, a.Seconds);
        }

        public static bool operator >(Duration a, Duration b)
        {
            if (a.Hourse * 3600 + a.Minute * 60 + a.Seconds > b.Hourse * 3600 + b.Minute * 60 + b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Duration a, Duration b)
        {
            if (a.Hourse * 3600 + a.Minute * 60 + a.Seconds < b.Hourse * 3600 + b.Minute * 60 + b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Duration a, Duration b)
        {
            if (a.Hourse * 3600 + a.Minute * 60 + a.Seconds <= b.Hourse * 3600 + b.Minute * 60 + b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Duration a, Duration b)
        {
            if (a.Hourse * 3600 + a.Minute * 60 + a.Seconds >= b.Hourse * 3600 + b.Minute * 60 + b.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return $"Hourse: {Hourse} Minutes: {Minute} Seconds: {Seconds}";
        }


        //ICoparable Generic
        //public int CompareTo(Duration other)
        //{
        //  if( this.Hourse !=other.Hourse) return 1;
        //    return -1;
        //}

        public static explicit operator DateTime(Duration D)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, D.Hourse, D.Minute, D.Seconds);
        }
    }
}
