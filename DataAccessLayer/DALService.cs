using DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALService
    {
        private readonly TestDBContext _context = new TestDBContext();

        public Response<object> AddEmployee(Employee model)
        {
            try
            {
                _context.Employees.Add(new Employee
                {
                    Name = model.Name,
                    Address = model.Address,
                    Type = model.Type,
                    EmploymentDate = DateTime.Now.Date
                });
                _context.SaveChanges();
                return new Response<object>(null);
            }
            catch (Exception ex)
            {

                return new Response<object>(ex);
            }

        }

        public Response<List<Employee>> ListEmployees()
        {
            try
            {
                var resp = _context.Employees.ToList();
                return new Response<List<Employee>>(resp);
            }
            catch (Exception ex)
            {

                return new Response<List<Employee>>(ex);
            }

        }
    }
}
