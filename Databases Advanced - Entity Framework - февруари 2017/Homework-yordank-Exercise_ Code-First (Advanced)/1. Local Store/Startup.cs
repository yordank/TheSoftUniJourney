using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Local_Store
{
    class Startup
    {
        static void Main(string[] args)
        {
            using (var context = new ProductContext())
            {

                Product product1 = new Product("milk", "Rodopea", "natural milk", 2.00M);
                Product product2 = new Product("bread", "Simit", "bread", 1.00M);
                Product product3 = new Product("cheese", "Izvor", "cheese", 3.00M);

                context.Products.Add(product1);
                context.Products.Add(product2);
                context.Products.Add(product3);


                context.SaveChanges();

            }

        }
    }
}
