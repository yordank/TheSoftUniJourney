using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Hospital_Database.Models
{
    public class Medicament
    {

        public Medicament(string name)
        {
            this.Name = name;
            patients = new HashSet<Patient>();
        }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Patient> patients { get; set; }
    }
}
