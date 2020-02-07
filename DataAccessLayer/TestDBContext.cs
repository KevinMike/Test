using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;
namespace DataAccessLayer
{
    public class TestDBContext : DbContext
    {
        public TestDBContext() : base(Globals.ConnectionString)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }

    }
}
