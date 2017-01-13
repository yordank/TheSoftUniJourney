using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Andrey_and_billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductQuatity { get; set; }
        public decimal Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> ProductPriceDictionary = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var ProductPrice = input.Split('-');

                string Product = ProductPrice[0];
                decimal Price = decimal.Parse(ProductPrice[1]);

                if (ProductPriceDictionary.ContainsKey(Product))
                {
                    ProductPriceDictionary[Product] = Price;
                }
                else
                    ProductPriceDictionary.Add(Product, Price);


            }

            string inputClients = Console.ReadLine();

            while (inputClients != "end of clients")
            {
                var ClientOtherPart = inputClients.Split('-');

                string Client = ClientOtherPart[0];
                var ProductQuantity = ClientOtherPart[1].Split(',');

                string Product = ProductQuantity[0];
                int Quantity = int.Parse(ProductQuantity[1]);

                Customer cust = new Customer();

                if (ProductPriceDictionary.ContainsKey(Product))
                {
                    if (customers.Where(x => x.Name == Client).Count() > 0)
                    {
                        cust = customers.Where(x => x.Name == Client).Single();

                        if (!cust.ProductQuatity.ContainsKey(Product))
                            cust.ProductQuatity.Add(Product, Quantity);
                        else
                            cust.ProductQuatity[Product] += Quantity;

                        // cust.Bill = cust.ProductQuatity.Sum(x => x.Value);
                        cust.Bill = cust.ProductQuatity.Sum(x => x.Value * ProductPriceDictionary[x.Key]);

                        customers.Where(x => x.Name == Client).Single().ProductQuatity= cust.ProductQuatity;
                        customers.Where(x => x.Name == Client).Single().Bill = cust.Bill;

                    }

                    else
                    {
                        cust.Name = Client;

                        Dictionary<string, int> dict = new Dictionary<string, int>();
                        dict.Add(Product, Quantity);

                        cust.ProductQuatity=dict;

                        cust.Bill = cust.ProductQuatity.Sum(x => x.Value*ProductPriceDictionary[x.Key]);
                        customers.Add(cust);
                    }


                }

                inputClients = Console.ReadLine();
            }

            foreach (var item in customers.OrderBy(x=>x.Name))
            {
                Console.WriteLine(item.Name);

                Console.Write(string.Join("\n",item.ProductQuatity.Select(x=>"-- "+x.Key+" - "+x.Value)));

                Console.WriteLine();

                Console.WriteLine($"Bill: {item.Bill:f2}");

            }


            Console.WriteLine($"Total bill: {customers.Sum(x=>x.Bill):f2}");
        }
    }
}
