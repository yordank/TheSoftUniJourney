using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();
            
            while(input!="Tournament")
            {

                var items = input.Split();


                Pokemon pokemon = new Pokemon(items[1],items[2],int.Parse(items[3]));

                if (!trainers.ContainsKey(items[0])) 
                {
                    Trainer trainer = new Trainer(items[0]);

                    trainers.Add(items[0], trainer);

                }
                 
                    trainers[items[0]].Pokemons.Add(pokemon);
                




                input = Console.ReadLine();

            }

            input = Console.ReadLine();

            while (input != "End")
            {

                foreach (var trainer in trainers)
                {
                    if(trainer.Value.ContainsPokemon(input))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        trainer.Value.decreaseAllPokemonsHealth();
                    }
                }




                input = Console.ReadLine();

            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.Value.Badges))
            {
                Console.WriteLine(trainer.Value.ToString());
            }


        }
    }
}
