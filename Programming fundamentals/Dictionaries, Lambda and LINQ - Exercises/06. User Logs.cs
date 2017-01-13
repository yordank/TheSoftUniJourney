using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string,Dictionary<string,int>> dict = new SortedDictionary<string, Dictionary < string,int >> ();


            while (input != "end")
            {
                string[] IpUser = input.Split();

                string IP = IpUser[0];
                string User = IpUser[2];

                IP = IP.Replace("IP=", "");
                User = User.Replace("user=", "");

                if (dict.ContainsKey(User))
                {

                    Dictionary<string, int> d = new Dictionary<string, int>();
                    d = dict[User];

                    if (d.ContainsKey(IP))
                    {
                        d[IP]++;
                    }
                    else
                    {
                        d.Add(IP, 1);
                    }


                    dict[User] = d;
                }
                else
                {
                    Dictionary<string, int> d = new Dictionary<string, int>();
                    d.Add(IP, 1);
                    dict.Add(User, d);
                }



                input = Console.ReadLine();
            }

            foreach (var item1 in dict)
            {
                Console.WriteLine($"{item1.Key}:");


                int count = item1.Value.Count();
                int i = 0;

                foreach (var item2 in item1.Value)
                {
                    if(i!=count-1)
                    Console.Write($"{item2.Key} => {item2.Value}, ");
                    else
                    Console.WriteLine($"{item2.Key} => {item2.Value}.");
                    i++;
                }

            }

        }
    }
}
