

namespace _3.Sales_Database
{
    using System.Data.Entity;
    using Models;
    public class InitializeAndSeed : DropCreateDatabaseAlways<SalesDatabaseContext>
    {
        protected override void Seed(SalesDatabaseContext context)
        {
            // TODO Create and insert sample records

            Product product1 = new Product("godji beri", 1.2, 23.99M);
            Product product2 = new Product("spirulina", 2.2, 25.99M);
            Product product3 = new Product("chia seeds", 5.2, 5.99M);
            Product product4 = new Product("banana", 9.2, 1.99M);
            Product product5 = new Product("carrot", 2.2, 0.99M);

            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.Products.Add(product4);
            context.Products.Add(product5);

            Customer customer1 = new Customer("Maria", "maria18@gmail.com", "12123123");
            Customer customer2 = new Customer("Anton", "toninajka@gmail.com", "22123123");
            Customer customer3 = new Customer("Ivan", "vankata@gmail.com", "32123123");
            Customer customer4 = new Customer("Pesho", "peshoIT@gmail.com", "42123123");
            Customer customer5 = new Customer("Simo", "simo@gmail.com", "52123123");


            context.Customers.Add(customer1);
            context.Customers.Add(customer2);
            context.Customers.Add(customer3);
            context.Customers.Add(customer4);
            context.Customers.Add(customer5);

            StoreLocation storelocation1 = new StoreLocation("Sofia");
            StoreLocation storelocation2 = new StoreLocation("Plovdiv");
            StoreLocation storelocation3 = new StoreLocation("Varna");
            StoreLocation storelocation4 = new StoreLocation("Burgas");
            StoreLocation storelocation5 = new StoreLocation("Ruse");

            context.StoreLocations.Add(storelocation1);
            context.StoreLocations.Add(storelocation2);
            context.StoreLocations.Add(storelocation3);
            context.StoreLocations.Add(storelocation4);
            context.StoreLocations.Add(storelocation5);

            Sale sale1 = new Sale(product1, customer1, storelocation3);
            Sale sale2 = new Sale(product3, customer2, storelocation1);
            Sale sale3 = new Sale(product1, customer1, storelocation2);
            Sale sale4 = new Sale(product2, customer3, storelocation3);
            Sale sale5 = new Sale(product4, customer1, storelocation1);
            Sale sale6 = new Sale(product4, customer4, storelocation4);

            context.Sales.Add(sale1);
            context.Sales.Add(sale2);
            context.Sales.Add(sale3);
            context.Sales.Add(sale4);
            context.Sales.Add(sale5);
            context.Sales.Add(sale6);

             


            context.SaveChanges();

            base.Seed(context);

        }

    }
}
