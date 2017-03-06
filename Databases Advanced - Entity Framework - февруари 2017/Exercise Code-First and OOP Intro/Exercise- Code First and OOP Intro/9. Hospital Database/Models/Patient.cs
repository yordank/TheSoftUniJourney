using _9.Hospital_Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Hospital_Database
{
    public class Patient
    {
        public Patient(string firstName,string lastName,string address,string email,string picture,DateTime d,bool isinsured)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.Picture = picture;
            this.DateofBirth = d;
            this.IsInsured = isinsured;
            this.medicamets = new HashSet<Medicament>();
            this.diagnoses = new HashSet<Diagnose>();
            this.visitations = new HashSet<Visitation>();
        }



        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(100)]
         
        public string LastName { get; set; }

        [StringLength(100)]
        [Required]
        public string Address { get; set; }


         

        [RegularExpression(@"(\w+[.-_]?)+\w@(\w+\.?)+\w")]
        [EmailAddress()]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

          
        public string Picture { get; set; }

        [Required]
        public DateTime DateofBirth { get; set; }

        public bool IsInsured { get; set; }

        public int medicamentId { get; set; }

        public virtual ICollection<Medicament> medicamets { get; set; }
            

        public virtual ICollection<Visitation> visitations { get; set; }

        public virtual ICollection<Diagnose> diagnoses { get; set; }
    }
}
