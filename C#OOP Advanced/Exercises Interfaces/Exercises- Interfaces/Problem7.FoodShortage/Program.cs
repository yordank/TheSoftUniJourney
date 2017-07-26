using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();

            IBuyer buyer = null;

            if (tokens.Count() == 3)
            {
                buyer = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
            }
            else
            {
                buyer = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
            }

            buyers.Add(tokens[0], buyer);

        }

        string name = Console.ReadLine();

        while (name != "End")
        {
            if (buyers.ContainsKey(name))
            {
                buyers[name].BuyFood();
            }

            name = Console.ReadLine();
        }

        Console.WriteLine(buyers.Sum(x => x.Value.Food));

    }
}

