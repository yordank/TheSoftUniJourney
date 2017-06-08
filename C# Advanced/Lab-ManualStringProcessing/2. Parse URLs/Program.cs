using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Parse_URLs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int indexOfServerProtocolSeparator = input.IndexOf("://");

            if (indexOfServerProtocolSeparator == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            if (input.IndexOf("://", indexOfServerProtocolSeparator + 3) != -1 ||
                input.IndexOf("/", indexOfServerProtocolSeparator + 3) == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }


            int indexOfResourceServerSeparator = input.IndexOf("/", indexOfServerProtocolSeparator+3);

             

            Console.WriteLine($"Protocol = {input.Substring(0,indexOfServerProtocolSeparator)}");

            Console.WriteLine($"Server = {input.Substring(indexOfServerProtocolSeparator+3,indexOfResourceServerSeparator-indexOfServerProtocolSeparator-3)}");


            Console.WriteLine($"Resources = {input.Substring(indexOfResourceServerSeparator+1)}");


        }
    }
}
