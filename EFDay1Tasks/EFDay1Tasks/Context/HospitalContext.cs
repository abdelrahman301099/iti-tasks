using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDay1Tasks.Enteties;

namespace EFDay1Tasks.Context
{
    internal class HospitalContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4Q3BJNA;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Neurse>().HasKey(n=>n.Id);
        }
        public virtual DbSet<Neurse> Neurses { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }





    }
}
