using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Google
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;

            this.Parents = new List<Parent>();

            this.Children = new List<Children>();

            this.Pokemon = new List<Pokemon>();
        }
        public string Name { get; set; }
        public List<Pokemon> Pokemon { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Children> Children { get; set; }
        public Car Car { get; set; }

        public Company Company { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name);

            sb.AppendLine("Company:");
         

            if (this.Company != null)
            sb.AppendLine(this.Company.ToString());
          

            sb.AppendLine("Car:");
    

            if (this.Car != null)
                sb.AppendLine(this.Car.ToString());

            sb.AppendLine("Pokemon:");



            if (this.Pokemon.Count > 0)
            {
                foreach (var pokemon in this.Pokemon)
                {
                    sb.AppendLine(pokemon.ToString());
                }
            }

            sb.AppendLine("Parents:");

            if (this.Parents.Count > 0)
            {
                foreach (var parent in this.Parents)
                {
                    sb.AppendLine(parent.ToString());
                }
            }

            sb.AppendLine("Children:");

            if (this.Children.Count > 0)
            {
                foreach (var child in this.Children)
                {
                    sb.AppendLine(child.ToString());
                }

            }



            return sb.ToString();


        }

    }
}
