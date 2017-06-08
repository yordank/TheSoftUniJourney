using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int startIndex = input.IndexOf("<upcase>");

            int endIndex = 0;

            while (startIndex != -1)
            {
                endIndex = input.IndexOf("</upcase>", endIndex + 1);

                string text = "";

                if (endIndex>startIndex)
                 text= input.Substring(startIndex + 8, endIndex - startIndex - 8);

                 
                input = input.Replace($"<upcase>{text}</upcase>", text.ToUpper());

                startIndex = input.IndexOf("<upcase>", startIndex + 1);
            }

            Console.WriteLine(input);

        }
    }
}
