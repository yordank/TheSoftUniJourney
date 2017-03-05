using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Create_User
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new UserContext();

            User user1 = new User()
            {
                Username = "admin",
                Password = "asdASD123!",
                Email = "asd@abv.bg",
                ProfilePicture = "10101010101",
                RegisteredOn = new DateTime(2000, 1, 1),
                LastTimeLoggedIn = new DateTime(2001, 1, 1),
                Age = 30,
                IsDeleted = false
            };

            User user2 = new User()
            {
                Username = "user1912",
                Password = "asdASD123!",
                Email = "asd1912@abv.bg",
                ProfilePicture = "10101010101",
                RegisteredOn = new DateTime(2009, 1, 1),
                LastTimeLoggedIn = new DateTime(2011, 1, 1),
                Age = 31,
                IsDeleted = false
            };

            try { 
                context.users.Add(user1);

                context.users.Add(user2);

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
