using _3.Sales_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sales_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SalesDatabaseContext();
            context.Database.Initialize(true);

            var products = context.Products;
            var customers = context.Customers;
            var storeLocations=context.StoreLocations;
            var sales = context.Sales;
            Console.WriteLine();
            foreach (var product in products)
            {
                Console.WriteLine($"  {product.Name} {product.Price} {product.Quantity}");
            }
            Console.WriteLine();
            foreach (var customer in customers)
            {
                Console.WriteLine($"  {customer.Name} {customer.Email} {customer.CreditCardNumber}");
            }
            Console.WriteLine();
            foreach (var storeLocation in storeLocations)
            {
                Console.WriteLine($"  {storeLocation.LocationName} ");
            }
            Console.WriteLine();
            foreach (var sale in sales)
            {
                Console.WriteLine($"  {sale.Id} {sale.Product.Name} {sale.Customer.Name} {sale.StoreLocation.LocationName}");
            }
        }
    }
}
