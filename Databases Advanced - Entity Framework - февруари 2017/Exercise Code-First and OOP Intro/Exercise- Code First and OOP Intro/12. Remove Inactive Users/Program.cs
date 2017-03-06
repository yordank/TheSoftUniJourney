using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Remove_Inactive_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());

            using (var context = new UserContext())
            {

                int deletedUsers = 0;

                foreach (var u in context.Users.Where(x => x.LastTimeLoggedIn < date && x.IsDeleted == false).ToList())
                {
                    u.IsDeleted = true;

                    context.Users.Attach(u);
                    context.Entry(u).State = EntityState.Modified;
                    deletedUsers++;
                    context.Users.Remove(u);
                }

                context.SaveChanges();


                string res = (deletedUsers == 0) ? "No" : deletedUsers.ToString();

                Console.WriteLine($"{res} users have been deleted");
            }
        }
    }
}
