using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<int>>> TypeNameStats = new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                string []input = Console.ReadLine().Split();
                string Type = input[0];
                string Name = input[1];

                int damage;
                int health;
                int armor;

                if (input[2] == "null")
                    damage = 45;
                else
                    damage = int.Parse(input[2]);

                if (input[3] == "null")
                    health = 250;
                else
                    health = int.Parse(input[3]);

                if (input[4] == "null")
                    armor = 10;
                else
                    armor = int.Parse(input[4]);

                Dictionary<string, List<int>> NameStats = new Dictionary<string, List<int>>();
                List<int> Stats = new List<int>(3);

                Stats.Add(damage);
                Stats.Add(health);
                Stats.Add(armor);

                if (TypeNameStats.ContainsKey(Type))
                {
                    

                    NameStats = TypeNameStats[Type];

                    if (NameStats.ContainsKey(Name))
                        NameStats[Name] = Stats;

                    else
                    NameStats.Add(Name, Stats);

                    TypeNameStats[Type] = NameStats;

                }
                else
                {
                    NameStats.Add(Name, Stats);
                    TypeNameStats.Add(Type, NameStats);
                }

            }

            foreach (var item in TypeNameStats)
            {
                decimal count = item.Value.Values.Count();
               
                decimal averageDamage = item.Value.Sum(x => x.Value[0])/count;
                decimal averageHealth = item.Value.Sum(x => x.Value[1])/count;
                decimal averageArmor = item.Value.Sum(x => x.Value[2])/count;

                Console.WriteLine($"{item.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                var t = item.Value.OrderBy(x => x.Key);

                foreach (var item2 in t)
                {
                 Console.WriteLine($"-{item2.Key} -> damage: {item2.Value[0]}, health: {item2.Value[1]}, armor: {item2.Value[2]}");
                }
            }

        }
    }
}
