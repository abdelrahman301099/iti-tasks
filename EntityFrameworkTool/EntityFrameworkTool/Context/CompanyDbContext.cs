using EntityFrameworkTool.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTool.Context
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4Q3BJNA;Database=Company;trusted_connection=True;Trust Server Certificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dapartment> Dapartments { get; set; }
    }
}
