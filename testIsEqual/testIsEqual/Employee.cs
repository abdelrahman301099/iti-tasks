using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testIsEqual
{
    internal struct Employee
    {
        int id;
        string name;
        int salary;

        public int ID
        {

            get; set;
        }
        public string Name
        {

            get; set;
        }
        public int Salary
        {
            get; set;
        }



        //public static bool operator ==(Employee left, Employee right)
        //{
        //    return left.Equals(right);
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    return !left.Equals(right);
        //}

    }
}
