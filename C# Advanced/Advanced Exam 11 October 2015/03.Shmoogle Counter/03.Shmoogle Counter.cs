using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Shmoogle_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> intVariables = new List<string>();
            List<string> doubleVariables = new List<string>();

            while (input != "//END_OF_CODE")
            {

                  
                    var matchInt = Regex.Match(input, "int\\s+([a-zA-Z]+)");
                    var matchDouble = Regex.Match(input, "double\\s+([a-zA-Z]+)");


                    while (matchInt.Success)
                    {

                    if (!Regex.Match(input, "public int").Success )
                        intVariables.Add(matchInt.Groups[1].Value);

                        matchInt = matchInt.NextMatch();

                    }

                    int i = 0;
                    while (matchDouble.Success)
                    {

                    if (!Regex.Match(input, "public double").Success && !Regex.Match(input, "static\\s+double").Success || i>0)
                        doubleVariables.Add(matchDouble.Groups[1].Value);

                    i++;
                        matchDouble = matchDouble.NextMatch();

                    }
                

                input = Console.ReadLine();
            }
            if(doubleVariables.Count()==0)
                Console.WriteLine("Doubles: None");
            else
                Console.WriteLine($"Doubles: {string.Join(", ",doubleVariables.OrderBy(x=>x))}");

            if(intVariables.Count()==0)
                Console.WriteLine("Ints: None");
            else
                Console.WriteLine($"Ints: {string.Join(", ", intVariables.OrderBy(x => x))}");
        }
    }
}
