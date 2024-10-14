using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmployeeStruct
{
   public class Employee
    {
        int id;
        double salary;
        HireDate hireDate;
        Gender gender;
        SecurityLevel secureteLevel;

       public int Id
        {

            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
      public  double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }


       public Gender Gender
        {
            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }


     public   SecurityLevel SecureteLevel
        {
            set
            {
                secureteLevel = value;
            }
            get
            {
                return secureteLevel;
            }
        }
      public  HireDate HireDate
        {
            set
            {
                hireDate = value;
            }
            get
            {
                return hireDate;
            }
        }

        public Employee()
        {

        }
        public Employee(int _id, double _salary, Gender _gender, HireDate _hireDate, SecurityLevel _securetylevel)
        {
            id = _id;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
            secureteLevel= _securetylevel;


        }


        public override string ToString()
        {
            return $" {id} : {Salary :C}:{hireDate}:{secureteLevel} : {gender}";
        }


    }
}
