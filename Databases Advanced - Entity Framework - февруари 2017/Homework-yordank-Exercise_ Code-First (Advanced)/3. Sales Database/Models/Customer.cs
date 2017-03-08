 


namespace _3.Sales_Database.Models
{
    using System.Collections.Generic;
    public class Customer
    {
        public Customer(string name,string email,string creditCardNumber)
        {
            this.Name = name;
            this.Email = email;
            this.CreditCardNumber = creditCardNumber;
            SalesForCustomer = new HashSet<Sale>();
        }
        public Customer()
        {
            SalesForCustomer = new HashSet<Sale>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
        public ICollection<Sale> SalesForCustomer { get; set; }

    }
}
