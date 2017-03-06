namespace _10.Hospital_Database_Modification
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HostitalContext : DbContext
    {
        public HostitalContext()
            : base("name=HostitalContext")
        {

        }

        public virtual DbSet<Diagnose> Diagnoses { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Visitation> Visitations { get; set; }

        public virtual DbSet<Doctor> Doctors { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diagnose>()
                .HasMany(e => e.Patients)
                .WithMany(e => e.Diagnoses)
                .Map(m => m.ToTable("PatientDiagnoses").MapLeftKey("Diagnose_Id"));

            modelBuilder.Entity<Medicament>()
                .HasMany(e => e.Patients)
                .WithMany(e => e.Medicaments)
                .Map(m => m.ToTable("MedicamentPatients"));

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Visitations)
                .WithOptional(e => e.Patient)
                .HasForeignKey(e => e.Patient_Id);


        }
    }
}
