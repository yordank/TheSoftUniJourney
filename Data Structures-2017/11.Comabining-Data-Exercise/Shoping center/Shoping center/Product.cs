using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping_center
{
    public class Product:IComparable<Product>
    {
        public Product(string name,decimal price,string producer)
        {
            this.Name = name;

            this.Price = price;

            this.Producer = producer;

        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Producer { get; set; }

        public int CompareTo(Product other)
        {
            int cmp = this.Name.CompareTo(other.Name);
            if (cmp==0)
            {
                cmp = this.Producer.CompareTo(other.Producer);
                if (cmp==0)
                {
                    cmp = this.Price.CompareTo(other.Price);
                }

            }

            return cmp;

            
        }

       
    }
}
