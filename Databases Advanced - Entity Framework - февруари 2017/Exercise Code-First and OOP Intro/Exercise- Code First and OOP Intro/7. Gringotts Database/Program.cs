using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Gringotts_Database
{
    class Program
    {
        static void Main(string[] args)
        {

            WizardDeposit doubledore = new WizardDeposit()
            {
                FirstName = "Albus",
                LastName = "Dumbledore",
                Age = 150,
                MagicWandCreator = "Antioch Peverell",
                MagicWandSize = 15,
                DepositStartDate = new DateTime(2016, 10, 20),
                DepositExpirationDate = new DateTime(2020, 10, 20),
                DepositAmount = 20000.24m,
                DepositCharge = 0.2,
                IsDepositExpired = false 
            };

            WizardDeposit astor = new WizardDeposit()
            {
                FirstName = "Antranik",
                LastName = "Arabadjian",
                Age = 73,
                MagicWandCreator = "Antioch Peverell",
                MagicWandSize = 25,
                DepositStartDate = new DateTime(1985, 10, 20),
                DepositExpirationDate = new DateTime(2120, 10, 20),
                DepositAmount = 1020000.24m,
                DepositCharge = 9.2,
                IsDepositExpired = false
            };

            var context = new GringottsContext();

            try
            {
                //context.wizardDeposit.Add(new WizardDeposit() { LastName = "Ivanov", Age = 29 });
                context.wizardDeposit.Add(astor);
                context.wizardDeposit.Add(doubledore);

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
