using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Teamwork_projects
{
    class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public string TeamLeader { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());


            string input = "";

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                var NameTeam = input.Split('-');
                if (NameTeam.Count() > 2)
                {
                    throw new Exception();
                }
                string UserName = NameTeam[0];
                string TeamName = NameTeam[1];

                int UserNameCount = teams.Where(x => x.TeamLeader == UserName).Count();
                int TeamNameCount = teams.Where(x => x.Name == TeamName).Count();


                //  if (UserNameCount == 0 && TeamNameCount==0)
                {

                }

                if (TeamNameCount == 1)
                {
                    Console.WriteLine($"Team {TeamName} was already created!");
                }
                else

                if (UserNameCount == 1)
                {
                    Console.WriteLine($"{UserName} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {TeamName} has been created by {UserName}!");
                    Team newTeam = new Team();
                    newTeam.Name = TeamName;
                    newTeam.TeamLeader = UserName;
                    newTeam.Members = new List<string>();
                    //newTeam.Members.Add(UserName);
                    teams.Add(newTeam);
                }



            }

            input = Console.ReadLine();

            while (input != "end of assignment")
            {
                var UserNameTeam = input.Replace("->", "*").Split('*');

                if (UserNameTeam.Count() > 2)
                    throw new Exception();

                string UserName = UserNameTeam[0];
                string TeamName = UserNameTeam[1];

                int a = teams.Where(x => x.TeamLeader == UserName).Count();
                int b = teams.Where(x => x.Members.Contains(UserName)).Count();
                int c = teams.Where(x => x.Name == TeamName).Count();
                int d = teams.Where(x => x.Name == TeamName && x.TeamLeader == UserName).Count();

                if (c == 0)
                {
                    Console.WriteLine($"Team {TeamName} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }
                else if (b > 0 || a > 0)
                {
                    Console.WriteLine($"Member {UserName} cannot join team {TeamName}!");
                    input = Console.ReadLine();
                    continue;
                }


                Team existTeam = new Team();

                existTeam.Name = teams.Where(x => x.Name == TeamName).First().Name;
                existTeam.Members = teams.Where(x => x.Name == TeamName).First().Members;

                existTeam.Members.Add(UserName);

                teams.Where(x => x.Name == TeamName).First().Members = existTeam.Members;

                input = Console.ReadLine();
            }


            foreach (var item in teams.Where(x => x.Members.Count() > 0).OrderBy(x => x.Name).OrderByDescending(x => x.Members.Count()))
            {

                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"- {item.TeamLeader}");
                item.Members.Sort();
                Console.WriteLine($"{string.Join("\n", item.Members.OrderBy(x => x).Select(x => "-- " + x))}");


            }

            Console.WriteLine("Teams to disband:");

            //  if (teams.Where(x => x.Members.Count() == 0))
            {
                int i = 1;

                foreach (var item in teams.OrderBy(x => x.Name).Where(x => x.Members.Count() == 0))
                {
                    // if(i==1)
                    Console.WriteLine($"{item.Name}");
                    //  Console.WriteLine($"- {item.TeamLeader}");

                    i++;
                }


            }



        }

    }
}

