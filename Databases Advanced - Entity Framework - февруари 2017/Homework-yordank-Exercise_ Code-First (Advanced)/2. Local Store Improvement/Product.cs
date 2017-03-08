namespace _2.Local_Store_Improvement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public Product(string name,string distributor,string description,decimal price,decimal weight,decimal quatity)
        {
            this.Name = name;

            this.Distributor = distributor;

            this.Description = description;

            this.Price = price;

            this.Weight = weight;

            this.Quatity = quatity;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Distributor { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Weight { get; set; }

        public decimal Quatity { get; set; }
    }
}
