using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace _07.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string town = input[0];
                string product = input[1];
                decimal price = decimal.Parse(input[2]);
                decimal quatity = decimal.Parse(input[3]);
                Sale sale = new Sale { Town = town, Product = product, Price = price, Quantity = quatity };
                sales.Add(sale);

            }

            var s = sales.Select(y => y.Town).Distinct().OrderBy(x => x);

            foreach (var item in s)
            {
              Console.WriteLine($"{item} -> {sales.Where(x=>x.Town==item).Sum(y=>y.Price*y.Quantity):f2}");
            }

        }
    }
}
