using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> UserDuration = new Dictionary<string, int>();
            Dictionary<string, List<string>> UserIps = new Dictionary<string, List<string>>();

            string[] input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                string IP = input[0];
                string User = input[1];
                int Duration = int.Parse(input[2]);

                if (UserDuration.ContainsKey(User))
                {
                    UserDuration[User] += Duration;
                }
                else
                {
                    UserDuration.Add(User, Duration);
                }

                List<string> listIps = new List<string>();

                if (UserIps.ContainsKey(User))
                {
                    listIps = UserIps[User];
                    listIps.Add(IP);
                    UserIps[User] = listIps.Distinct().ToList();
                }
                else
                {
                    listIps.Add(IP);
                    UserIps.Add(User, listIps);
                }

            }

            var newUserDuration = UserDuration.OrderBy(x => x.Key);

            foreach (var item in newUserDuration)
            {

                var listOrderedIps = UserIps[item.Key];
                listOrderedIps.Sort();

                Console.WriteLine($"{item.Key}: {item.Value} [{String.Join(", ",listOrderedIps)}]");

            }






        }
    }
}
