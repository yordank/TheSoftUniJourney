using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Cat_Lady
{
    public class Siamese:Cat
    {
        public Siamese(string Name,int EarSzie)
        {
            this.Name = Name;

            this.EarSize = EarSize;

        }
        public string Name { get; set; }

        public int EarSize { get; set; }
        public override void PrintInformation()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Siamese {this.Name} {this.EarSize}";
        }
    }
}
