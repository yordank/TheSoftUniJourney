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

        while(line!="End")
        {
            var tokens = line.Split();

            IResident citizen1 = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));

            IPerson citizen2 = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                        
            Console.WriteLine(citizen1.GetName());

            Console.WriteLine(citizen2.GetName());

            line = Console.ReadLine();
        }

    }

}

