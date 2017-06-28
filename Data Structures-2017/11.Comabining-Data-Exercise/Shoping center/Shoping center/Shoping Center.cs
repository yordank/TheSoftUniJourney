using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Shoping_center
{
    public class ShopingCenter
    {
         

        public Dictionary<string,Bag<Product>> byNameProducer=new Dictionary<string, Bag<Product>>();

        public Dictionary<string, OrderedBag<Product>> FindByName=new Dictionary<string, OrderedBag<Product>>();

        public Dictionary<string, OrderedBag<Product>> FindByProducer=new Dictionary<string, OrderedBag<Product>>();

        public OrderedDictionary<decimal,  Bag<Product>> FindProductsByPriceRange=new OrderedDictionary<decimal, Bag<Product>>();

        public void AddProduct(string name,decimal price,string producer)
        {
            var product = new Product(name, price, producer);

            this.byNameProducer.AppendValueToKey(name+producer,product);

            this.FindByName.AppendValueToKey(name, product);

            this.FindByProducer.AppendValueToKey(producer, product);

            if(!FindProductsByPriceRange.ContainsKey(price))
            {
                var newSet = new Bag<Product>();

                newSet.Add(product);

                FindProductsByPriceRange.Add(price,newSet);

            }
            else
            {
                FindProductsByPriceRange[price].Add(product);
            }


            Console.WriteLine("Product added");

        }

        public void DeleteByProducer(string producer)
        {
            if(!FindByProducer.ContainsKey(producer))
            {
                Console.WriteLine("No products found");
                return;
            }

            var deleted = FindByProducer[producer];

            this.FindByProducer.Remove(producer);

            foreach (var product in deleted)
            {
                FindByName[product.Name].Remove(product);

                byNameProducer[product.Name + product.Producer].Remove(product);

                FindProductsByPriceRange[product.Price].Remove(product);
            }

            Console.WriteLine($"{deleted.Count} products deleted");

        }

        public void DeleteByNameAndProducer(string name,string producer)
        {
            var key = name + producer;

            if(!byNameProducer.ContainsKey(key))
            {
                Console.WriteLine("No products found");
                return;
            }

            var deleted = byNameProducer[key];

            this.byNameProducer.Remove(key);

            foreach (var product in deleted)
            {
                FindByName[product.Name].Remove(product);

                FindByProducer[product.Producer].Remove(product);

                FindProductsByPriceRange[product.Price].Remove(product);
            }

            Console.WriteLine($"{deleted.Count} products deleted");


        }

        public void FindProductsByName(string name)
        {
            if(!FindByName.ContainsKey(name))
            {
                Console.WriteLine("No products found");
                return;
            }
            if(FindByName[name].Count==0)
            {
                Console.WriteLine("No products found");
                return;
            }

            foreach (var product in FindByName[name])
            {
                Console.WriteLine($"{{{product.Name};{product.Producer};{string.Format("{0:f2}",product.Price)}}}");
            }

        }

        public void FindProductsByProducer(string producer)
        {
            if (!FindByProducer.ContainsKey(producer))
            {
                Console.WriteLine("No products found");
                return;
            }

            if (FindByProducer[producer].Count == 0)
            {
                Console.WriteLine("No products found");
                return;
            }

            foreach (var product in FindByProducer[producer])
            {
                Console.WriteLine($"{{{product.Name};{product.Producer};{string.Format("{0:f2}", product.Price)}}}");
            }
        }

        public void FindProductsByPriceRangeFunc(decimal start,decimal end)
        {
            var products = FindProductsByPriceRange.Range(start, true, end, true);

            if(products.Count==0)
            {
                Console.WriteLine("No products found");
                return;
            }

            OrderedBag<Product> result = new OrderedBag<Product>();


            foreach (var items in products)
            {
                foreach (var item in items.Value)
                {
                    result.Add(item);
                }
            }

            foreach (var product in result)
            {
                Console.WriteLine($"{{{product.Name};{product.Producer};{string.Format("{0:f2}", product.Price)}}}");
            }

        }




    }
}
