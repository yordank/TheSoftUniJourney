﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.Get_Users_by_Email_Provider
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            using (var context = new UserContext())
            {
                Regex reg = new Regex($"{input}$");
                var users = context.Users.ToList().Where(x => reg.Match(x.Email).Success).ToList();

                foreach (var u in users)
                {
                    Console.WriteLine($"{u.Username} {u.Email}");
                }
            }


        }

      


    }
}
