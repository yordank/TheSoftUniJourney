using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Jedi_Code_X
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> message = new List<string>();

            int n = int.Parse(Console.ReadLine());
            string lines = "";

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                lines += "\n" + line;
            }

            string prefixPattern1 = Console.ReadLine();
            string prefixPattern2 = Console.ReadLine();

            string pattern1 = prefixPattern1 + $"([a-zA-Z]{{{prefixPattern1.Count()}}})"+ "(?![A-Za-z])";
            string pattern2 = prefixPattern2 + $"([a-zA-Z0-9]{{{prefixPattern2.Count()}}})"+ "(?![A-Za-z])";

            Regex regex1 = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);

            var matches1 = Regex.Matches(lines, pattern1);

            foreach (Match item in matches1)
            {

                names.Add(item.Groups[1].Value);
            }

            var matches2 = Regex.Matches(lines, pattern2);

            foreach (Match item in matches2)
            {

                message.Add(item.Groups[1].Value);
            }

            var indexes = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToList();
            int j = 0;


            int flag = 0;

            for (int i = 0; i < names.Count(); i++)
            {
                if(flag==1)
                    Console.WriteLine($"{names[i]} - {message[indexes[1]]}");

                if (j < indexes.Count)
                {
                    if (message.Count > 0 && indexes[j] >= 0 && indexes[j] < message.Count)
                    {
                        Console.WriteLine($"{names[i]} - {message[indexes[j]]}");
                        j++;
                    }
                    else
                    {


                        if (indexes[j] < 0)
                        {
                            Console.WriteLine($"{names[i]} - {message[indexes[0]]}");
                        }
                        else
                        {
                            if (i != names.Count - 1)
                            {
                                Console.WriteLine($"{names[i]} -");
                                if (i == names.Count - 2)
                                    flag = 1;
                            }
                        }

                    }

                }
            }

        }
    }
}
