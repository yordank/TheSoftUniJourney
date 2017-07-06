using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            List<Product> products = new List<Product>();

            ReadPeople(people);

            ReadProducts(products);

            string input = Console.ReadLine();

            while (input != "END")
            {
                var items = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                


                    var personName = items[0];

                    var productName = items[1];

                    if (string.IsNullOrWhiteSpace(personName) || string.IsNullOrEmpty(personName))
                    {
                        Console.WriteLine("Name cannot be empty");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrEmpty(productName))
                    {
                        Console.WriteLine("Name cannot be empty");
                        return;
                    }
                    var person = people.Where(x => x.Name == personName).FirstOrDefault();

                    var product = products.Where(x => x.Name == productName).FirstOrDefault();

                    person.BuyProduct(product);

                 
               
                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.ProductBag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                    continue;
                }
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.ProductBag.Select(x => x.Name))}");
            }

        }

        private static void ReadProducts(List<Product> products)
        {
            var inputProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in inputProducts)
            {
                string name = product.Split('=')[0].Trim();

                decimal costs = decimal.Parse(product.Split('=')[1].Trim());

                Product p = new Product(name, costs);

                products.Add(p);

            }
        }

        private static void ReadPeople(List<Person> people)
        {



            var inputPeople = Console.ReadLine().Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in inputPeople)
            {
                Person p = null;
                try
                {
                    string name = person.Split('=')[0].Trim();

                    decimal money = decimal.Parse(person.Split('=')[1].Trim());
                    
                    try
                    {
                        p = new Person(name, money);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

                people.Add(p);
            }


        }
    }
}
