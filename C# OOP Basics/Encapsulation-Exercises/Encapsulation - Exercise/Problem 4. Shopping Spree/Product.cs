using System;


public class Product
    {
        public Product(string name,decimal costs)
        {
            this.Name = name;

            this.Costs = costs;

        }
        private string name;

        private decimal costs;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value!="" && value!=null)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }
        public decimal Costs
        {
            get
            {
                return this.costs;
            }
            set
            {
                if (costs < 0)
                {
                    throw new ArgumentException("Costs caonnot be negative");
                }
                else
                    this.costs = value;
            }

        }


    }

 
