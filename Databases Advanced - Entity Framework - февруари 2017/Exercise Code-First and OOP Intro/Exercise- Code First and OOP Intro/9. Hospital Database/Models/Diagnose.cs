using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Hospital_Database.Models
{
    public class Diagnose
    {
        public Diagnose(string name,string comments)
        {
            this.Name = name;
            this.Comment = comments;
            this.patients = new HashSet<Patient>();

        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Patient> patients { get; set; }
    }
}
