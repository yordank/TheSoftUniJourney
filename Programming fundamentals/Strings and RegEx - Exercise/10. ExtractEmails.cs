using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Extract_emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"^([a-zA-Z0-9]{1}([a-z0-9A-Z-_\.])*[a-zA-Z0-9]{1})@([a-zA-Z0-9]{1}([a-zA-Z0-9-\._])*\.(\w)+)";

            Regex reg = new Regex(pattern);

            while (input != "end")
            {
                var input1 = input.Split(new char[] { ' ', ',', '!', '?' });
                foreach (var item in input1)
                {
                    if (reg.IsMatch(item))
                    {
                        var match = reg.Matches(item);
                        foreach (var item1 in match)
                        {
                            Console.WriteLine(item1);
                        }

                    }

                }
                input = Console.ReadLine();
            }


        }
    }
}
