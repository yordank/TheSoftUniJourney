 

 
namespace _3.Sales_Database.Models
{
    using System.Collections.Generic;
    public class Product
    {
        public Product(string name,double quatity,decimal price)
        {
            this.Name = name;
            this.Quantity = quatity;
            this.Price = price;
            SalesOfProduct = new HashSet<Sale>();
        }
        public Product()
        {
            SalesOfProduct = new HashSet<Sale>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public ICollection<Sale> SalesOfProduct { get; set; }

    }
}
