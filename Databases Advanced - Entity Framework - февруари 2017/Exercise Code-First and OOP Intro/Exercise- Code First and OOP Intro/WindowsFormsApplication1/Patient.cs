namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Visitations = new HashSet<Visitation>();
            Medicaments = new HashSet<Medicament>();
            Diagnoses = new HashSet<Diagnosis>();
        }
        public Patient(string firstName, string lastName, string address, string email, string picture, DateTime d, bool isinsured)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.Picture = picture;
            this.DateofBirth = d;
            this.IsInsured = isinsured;
            this.Medicaments = new HashSet<Medicament>();
            this.Diagnoses = new HashSet<Diagnosis>();
            this.Visitations = new HashSet<Visitation>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        public string Picture { get; set; }

        public DateTime DateofBirth { get; set; }

        public bool IsInsured { get; set; }

        public int medicamentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitation> Visitations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicament> Medicaments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
    }
}
