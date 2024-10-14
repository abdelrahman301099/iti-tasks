using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Tasks
{
    class Math
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public static double Add(double a, double b) { return a + b; }
        public static double Multiply(double a, double b) { return a * b; }
        public static double Sub(double a, double b) { return a - b; }
        public static double Divid(double a, double b) { return a / b; }// Zero handling
    }
}
