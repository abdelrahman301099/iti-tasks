namespace testIsEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { ID=10, Salary= 20_000, Name="Younis"};
            Employee emp2 = new Employee() { ID = 10, Salary = 20_000, Name = "Younis" };
          bool flag=  emp1.Equals(emp2);
            Console.WriteLine(flag);

            //Employee emp3 = new Employee() { ID = 10, Salary = 20_000, Name = "Younis" };
            //Employee[] employees ={ emp1, emp2 };
            //int v = Mega<Employee>.SearchInArr(employees, emp3);
            //Console.WriteLine(v);

        }
    }
}
