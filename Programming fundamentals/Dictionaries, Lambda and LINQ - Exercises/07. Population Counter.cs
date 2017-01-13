using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var PopulationDictionary = new Dictionary<string, Dictionary<string, long>>();

             while (input != "report")
            {
                string[] CityCountryPopulation = input.Split('|');

                string City = CityCountryPopulation[0];
                string Country = CityCountryPopulation[1];
                long Population = long.Parse(CityCountryPopulation[2]);

                var CityPopulation = new Dictionary<string, long>();


                if (PopulationDictionary.ContainsKey(Country))
                {
                    
                    CityPopulation = PopulationDictionary[Country];

                    if (CityPopulation.ContainsKey(City))
                    {
                        CityPopulation[City] += Population;
                    }
                    else
                    CityPopulation.Add(City, Population);

                    PopulationDictionary[Country] = CityPopulation;

                }
                else
                {
                    CityPopulation.Add(City, Population);
                    PopulationDictionary.Add(Country, CityPopulation);

                }

                input = Console.ReadLine();
            }

            var dict = PopulationDictionary.OrderBy(x => -x.Value.Sum(y => y.Value));

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Sum(x=>x.Value)})");
                var citydict = item.Value.OrderBy(x => -x.Value);

                foreach (var item2 in citydict)
                {
                    Console.WriteLine($"=>{item2.Key}: {item2.Value}");
                }
                
                           
            }


        }
    }
}
