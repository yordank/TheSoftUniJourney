using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Hospital_Database_Modification
{
    public class Doctor

    {

        public Doctor(string Name,string Speciality,string Email,string Password)
        {
            this.Name = Name;
            this.Speciality = Speciality;
            this.Email = Email;
            this.Password = Password;

            this.visitations = new HashSet<Visitation>();
        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public string Name{get;set;}
        public string Speciality { get; set; }

        [RegularExpression(@"(\w+[.-_]?)+\w@(\w+\.?)+\w")]
        [EmailAddress()]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Visitation> visitations { get; set; }

    }
}
