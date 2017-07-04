using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Cat_Lady
{
    public class Cymric:Cat
    {
        public Cymric(string name,double length)
        {
            this.Name = name;
            this.FurLength = length;
        }
        public string Name { get; set; }

        public double FurLength { get; set; }
        public override void PrintInformation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Cymric {this.Name} {this.FurLength:f2}";
        }
    }
}
