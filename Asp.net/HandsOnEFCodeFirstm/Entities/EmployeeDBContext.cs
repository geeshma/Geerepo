using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEFCodeFirstm.Entities
{
    class EmployeeDBContext:DbContext
    {
        //Entity set
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //set connection string
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-HBQQ1KH2\SQLEXPRESS;Initial Catalog=EmployeeDB5;Integrated Security=True");
        }
    }
}
