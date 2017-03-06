namespace _9.Hospital_Database
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;


    public class PatientContext : DbContext
    {
        // Your context has been configured to use a 'PatientContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_9.Hospital_Database.PatientContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PatientContext' 
        // connection string in the application configuration file.
        public PatientContext()
            : base("name=PatientContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Patient> patients { get; set; }

         public virtual DbSet<Medicament> medicaments { get; set; }

        public virtual DbSet<Visitation> visitations { get; set; }

        public virtual DbSet<Diagnose> diagnoses { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}