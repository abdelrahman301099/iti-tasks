using EFDay1DBFirst.Models;

namespace EFDay1DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Company_SDContext company_SDContext = new Company_SDContext();

            //Employee emp01 = new Employee() { Fname = "Ali", Lname = "Samir", Address = "Giza", Dno = 10 };
            //company_SDContext.Employees.Add(emp01);
            //company_SDContext.SaveChanges();






            //var emp03 = (from emp in company_SDContext.Employees
            //             where emp.Fname == "Ali"
            //             select emp).FirstOrDefault();
            //if (emp03 != null)
            //{
            //    emp03.Fname = "Hkaled";
            //}




            
            var emp02 = (from emp in company_SDContext.Employees
                         where emp.Fname == "Ali"
                         select emp).FirstOrDefault();
            if (emp02 != null)
            {
                company_SDContext.Remove(emp02);
            }

        }
    }
}
