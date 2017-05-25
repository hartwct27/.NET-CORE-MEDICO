using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace TESTCORE.Models
{
    public class NorthwindDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =KRSJOKOSU-NB02; Initial Catalog =TEST; Integrated security = true");
        }
    }
}
