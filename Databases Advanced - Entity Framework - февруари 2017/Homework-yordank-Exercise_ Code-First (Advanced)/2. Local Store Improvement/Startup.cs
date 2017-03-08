using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Local_Store_Improvement
{
    class Startup
    {
        static void Main(string[] args)
        {
            using (var context = new ProductContext())
            {
                context.Products.Add(new Product("yellowcheese", "vitosha", "cheese with lemon concentrat", 2.34M, 3, 4));
                context.SaveChanges();
            }

        }
    }
}
