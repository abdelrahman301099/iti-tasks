namespace Day8EmployeeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    Employee[] employees = new Employee[3];

            //    for (int i = 0; i < employees.Length; i++)
            //    {


            //        employees[i] = new Employee();
            //        Console.WriteLine("Enter ID");
            //        employees[i].Id = int.Parse(Console.ReadLine());

            //        //e1.Id = 2;
            //        Console.WriteLine("Enter Saalry");
            //        employees[i].Salary = double.Parse(Console.ReadLine());
            //        //e1.Salary = 2500;

            //        Console.WriteLine(" Enter the Gender (M or F)");
            //        string gen = Console.ReadLine();
            //        if (gen.ToLower() == "m")
            //        {
            //            employees[i].Gender = Gender.male;
            //        }
            //        else
            //        {
            //            employees[i].Gender = Gender.female;
            //        }

            //        // e1.Gender = Gender.male;
            //        Console.WriteLine("Enter security Level DBA, Developer, Secrtary or Guest");
            //        string SL = Console.ReadLine();

            //        if (SL.ToLower() == "dba")
            //        {
            //            employees[i].SecureteLevel = SecurityLevel.DBA;

            //        }
            //        else if (SL.ToLower() == "developre")
            //        {
            //            employees[i].SecureteLevel = SecurityLevel.developer;

            //        }
            //        else if (SL.ToLower() == "secrtary")
            //        {
            //            employees[i].SecureteLevel = SecurityLevel.secretary;

            //        }
            //        else
            //        {
            //            employees[i].SecureteLevel = SecurityLevel.developer;
            //        }

            //        // e1.SecureteLevel = SecurityLevel.DBA;

            //        HireDate h = new HireDate();
            //        Console.WriteLine("Enter Your Hiring Year");
            //        h.Year = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter Your Hiring Monthe");
            //        h.Month = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter Your Hiring Day");
            //        h.day = int.Parse(Console.ReadLine());

            //        employees[i].HireDate = h;
            //    }

            //    for (int i = 0; i < employees.Length; i++)
            //    {
            //        Console.WriteLine(employees[i]);
            //    }
            Employee emp = new Employee() { Id = 123, Gender = Gender.male, HireDate = new HireDate(2022, 12, 12), Salary = 12000, SecureteLevel = SecurityLevel.guest };


            emp.SecureteLevel = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine());
            Console.WriteLine(emp);
        }
    }
}
