using EFDay1Tasks.Context;
using EFDay1Tasks.Enteties;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;


namespace EFDay1Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HospitalContext hospitalContext = new HospitalContext();



            hospitalContext.Database.EnsureCreated();

            Ward w = new() { Name = "DD" };

            hospitalContext.Wards.Add(w);


            Neurse nrs = new Neurse() { Name = "Alia", Salary = 12000, ward = w };
            hospitalContext.Add(nrs);



            hospitalContext.SaveChanges();




            //Neurse neurse = hospitalContext.Neurses.FirstOrDefault(s => s.Name.Contains("Ali"));
            //if (neurse != null)
            //{
            //    neurse.Name = "Aliaa"; //Update
            //                           // hospitalContext.Neurses.Remove(neurse);   // Delet
            //}



            //hospitalContext.SaveChanges();

        }
    }
}
