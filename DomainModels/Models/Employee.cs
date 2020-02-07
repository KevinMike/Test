using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        public int Type { get; set; }
        [ForeignKey("Type")]
        public virtual EmploymentType EmploymentType { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
