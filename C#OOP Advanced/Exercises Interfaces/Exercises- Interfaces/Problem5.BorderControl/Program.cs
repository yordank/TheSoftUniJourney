using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        List<ICitizen> citizensAndRobots = new List<ICitizen>();

        while(line!="End")
        {
            var tokens =line.Split();

            if(tokens.Count()==2)
            {
                var robot = new Robot(tokens[0], tokens[1]);

                citizensAndRobots.Add(robot);
            }
            else
            {
                var citizen = new Citizen(tokens[0], int.Parse(tokens[1]),tokens[2]);

                citizensAndRobots.Add(citizen);

            }

            line = Console.ReadLine();
        }

        string num = Console.ReadLine();

        foreach (var citizen in citizensAndRobots)
        {
            if(citizen.CheckIdEnds(num))
            {
                Console.WriteLine(citizen.Id);
            }
        }

    }
}

