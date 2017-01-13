using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_13.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\w|\s])*=([\w|\s]*)";

            Regex reg = new Regex(pattern);
            Regex reg1 = new Regex(@"\s+");
            Regex reg2 = new Regex(@"(.*)=(https|http|ftp)(.*)");

            while (input != "END")
            {
                input = input.Replace("%20", " ").Replace("+", " ");

              

                if (reg2.IsMatch(input))
                {
                    var m = reg2.Match(input);

                    string key = m.Groups[1].Value.Trim();
                    key = Regex.Replace(key, @"\s+", " ");
                    string value = (m.Groups[2].Value+m.Groups[3].Value).Trim();
                    value = Regex.Replace(value, @"\s+", " ");
                    Console.WriteLine($"{key}=[{value}]");
                    input = Console.ReadLine();
                    continue;
                }

                var items = input.Split(new char[] { '&', '?' });

                Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

                foreach (var item in items)
                {
                    // var item1 = item.Trim();
                    if (reg.IsMatch(item))
                    {
                        var match = reg.Match(item);
                        List<string> list = new List<string>();

                        string key = match.Value.Split('=')[0].Trim();
                        key = Regex.Replace(key, @"\s+", " ");
                        string value = match.Value.Split('=')[1].Trim();
                        value = Regex.Replace(value, @"\s+", " ");

                        int a = 5;

                        if (!dic.ContainsKey(key))
                        {
                            list.Add(value);
                            dic.Add(key, list);
                        }
                        else
                        {
                            list = dic[key];
                            list.Add(value);
                            dic[key] = list;
                        }

                    }


                }

                foreach (var item in dic)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }

        }
    }
}
