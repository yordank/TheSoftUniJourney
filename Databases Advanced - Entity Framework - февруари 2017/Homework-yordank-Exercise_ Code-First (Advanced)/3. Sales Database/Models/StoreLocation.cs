 


namespace _3.Sales_Database.Models
{
    using System.Collections.Generic;

    public class StoreLocation
    {
        public StoreLocation(string locationName)
        {
            this.LocationName = locationName;
            SalesInStore = new HashSet<Sale>();
        }
        public StoreLocation()
        {
            SalesInStore = new HashSet<Sale>();
        }

        public int Id { get; set; }

        public string LocationName { get; set; }

        public ICollection<Sale> SalesInStore { get; set; }

    }
}
