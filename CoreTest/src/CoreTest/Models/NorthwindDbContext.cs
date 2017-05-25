using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


namespace WebAPIInAspNetCore.Models
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }




        public NorthwindDbContext()
        {

        }




        public NorthwindDbContext(DbContextOptions options) : base(options)
        {

        }





        protected override void OnConfiguring
             (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog = northwind;integrated security = true");
        }
    }
}
