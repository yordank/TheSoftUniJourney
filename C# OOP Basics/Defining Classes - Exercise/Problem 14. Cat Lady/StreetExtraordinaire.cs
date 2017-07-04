using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Cat_Lady
{
    public class StreetExtraordinaire:Cat
    {
        public StreetExtraordinaire(string name,int decibels)
        {
            this.Name = name;

            this.decibels = decibels;
        }


        public string Name { get; set; }

        public int decibels { get; set; }

        public override void PrintInformation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.Name} {this.decibels}";
        }
    }
}
