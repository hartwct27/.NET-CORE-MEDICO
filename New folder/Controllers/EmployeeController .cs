using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using TESTCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace TESTCORE.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public List<Employee> Get()
        {
            using (NorthwindDbContext db = new
               NorthwindDbContext())
            {
                return db.Employees.ToList();
            }
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            using (NorthwindDbContext db = new
               NorthwindDbContext())
            {
                return db.Employees.Find(id);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Employee obj)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                db.Employees.Add(obj);
                db.SaveChanges();
                return new ObjectResult("Employee added successfully!");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Employee obj)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                db.Entry<Employee>(obj).State = EntityState.Modified;
                db.SaveChanges();
                return new ObjectResult("Employee modified successfully!");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {

                db.Employees.Remove(db.Employees.Find(id));
                db.SaveChanges();
                return new ObjectResult("Employee deleted successfully!");
            }
        }
    }
}
