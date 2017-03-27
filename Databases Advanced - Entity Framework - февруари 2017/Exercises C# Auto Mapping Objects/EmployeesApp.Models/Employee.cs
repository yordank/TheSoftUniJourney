using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Subordinates = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime? Birthday { get; set; }

        public string Address { get; set; }

        public bool isOnHoliday { get; set; }

        public virtual Employee manager { get; set; }

        public virtual ICollection<Employee> Subordinates { get; set; }

       

    }
}
