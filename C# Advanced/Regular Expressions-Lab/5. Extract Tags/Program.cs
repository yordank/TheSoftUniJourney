using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                str.Append(inputLine);

                str.Append(Environment.NewLine);

                inputLine = Console.ReadLine();
            }

            Regex regex = new Regex(@"<(.*?)>");

            var matches = regex.Matches(str.ToString());

            foreach (var tag in matches)
            {
                Console.WriteLine(tag);
            }



        }
    }
}
