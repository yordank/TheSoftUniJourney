using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Hospital_Database_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new HostitalContext())
            {
                 var visitation=context.Visitations.ToList().First();
           
                Doctor doctor = new Doctor("Ivanov", "Ears", "Petrov@gmail.com", "1234");
                doctor.visitations.Add(visitation);
                context.Doctors.Add(doctor);
                context.SaveChanges();
            }

        }
    }
}
