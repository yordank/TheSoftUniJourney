using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            while (userName!="END")
            {
                Regex regex = new Regex(@"^[a-zA-Z0-9_-]{3,16}$");

                if (regex.IsMatch(userName))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                userName = Console.ReadLine();
            }

        }

    }
}
