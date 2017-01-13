using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (name!="stop")
            {
                string email = Console.ReadLine();

                List<string> parts = email.Split('.').ToList();

                if (parts.Last().ToUpper() != "US" && parts.Last().ToUpper() != "UK")
                {
                    if (emails.ContainsKey(name))
                        emails[name] = email;
                    else
                        emails.Add(name, email);
                }

                name = Console.ReadLine();

            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }




        }
    }
}
