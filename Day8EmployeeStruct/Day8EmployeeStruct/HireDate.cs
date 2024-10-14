using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmployeeStruct
{
   public struct HireDate
    {

        public int year;
        public int month;
        public int day;
       

        public HireDate(int _year, int _month, int _day)
        {
            //_year = DateTime.Now.Year;
            year = _year;
            // _month = DateTime.Now.Month;
            month = _month;
            //_day = DateTime.Now.Day;
            day = _day;

        }



        public int Year
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }

        public int Month
        {
            set
            {
                month = value;
            }
            get
            {
                return month;
            }
        }

        public int Day
        {
            set
            {
                day = value;
            }
            get
            {

                return day;
            }
        }
        public override string ToString()
        {
            return $" Day:{day} : Month: { month} : Year: {year} ";
        }
    }
}
