using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Pokemon_Trainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;

            this.Badges = 0;

            this.Pokemons = new List<Pokemon>();

        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public bool ContainsPokemon(string element)
        {
            foreach (var pokemon in this.Pokemons)
            {
                if(pokemon.Element==element)
                {
                    return true;
                }

            }

            return false;
        }


        public void decreaseAllPokemonsHealth()
        {
            if (this.Pokemons.Count > 0)
            {
                foreach (var pokemon in this.Pokemons)
                {
                    if (pokemon.Health <= 10)
                    {
                        this.Pokemons.Remove(pokemon);
                        break;
                    }

                    else
                        pokemon.Health -= 10;
                }
            }

        }
    
        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }


    }
}
