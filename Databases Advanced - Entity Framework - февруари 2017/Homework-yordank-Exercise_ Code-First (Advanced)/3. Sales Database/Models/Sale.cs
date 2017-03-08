

namespace _3.Sales_Database.Models
{

    using System;
    public class Sale
    {
        public Sale(Product product,Customer customer,StoreLocation storeLocation)
        {
            this.Product = product;
            this.Customer = customer;
            this.StoreLocation = storeLocation;
            this.Date =  DateTime.Now;

        }
        public Sale()
        {

        }
        public int Id { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public DateTime Date { get; set; }

    }
}
