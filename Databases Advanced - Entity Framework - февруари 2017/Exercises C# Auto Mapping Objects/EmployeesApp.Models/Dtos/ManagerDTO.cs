using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Models.Dtos
{
    public class ManagerDTO
    {

        public ManagerDTO()
        {
            this.subordinates = new HashSet<EmployeeDTO>();
        }
        public string  FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<EmployeeDTO> subordinates { get; set; }

        public int SubordinatesCount { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.FirstName} {this.LastName} | Employees: {this.SubordinatesCount}");

            foreach (var emp in this.subordinates)
            {
                sb.AppendLine(emp.ToString());
            }

            return sb.ToString();

        }
    }
}
