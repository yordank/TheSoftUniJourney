using _9.Hospital_Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Hospital_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicament medicament = new Medicament("Biseptol");
            Patient p = new Patient(

                "Hrisi",
                "Ivanova",
                "Sofia",
                "maria18@abv.bg",
                "10000000",
                new DateTime(1988, 12, 12),
                true
            );

            using (var context = new PatientContext())
            {

               
                try
                {
                    p.medicamets.Add(medicament);
                    p.visitations.Add(new Visitation(new DateTime(2017, 3, 6), "visitation"));
                    p.diagnoses.Add(new Diagnose("nastinka", "hrema,kashlica i t.n"));
                    context.patients.Add(p);

                    context.SaveChanges();
                }

                catch (DbEntityValidationException dbEx)
                {

                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }


                }
            }
        }
    }
}
