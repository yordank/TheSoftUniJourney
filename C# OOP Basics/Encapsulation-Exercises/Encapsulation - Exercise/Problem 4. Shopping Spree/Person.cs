using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public Person(string name,decimal money)
    {
        this.Name = name;

        this.Money = money;

        ProductBag = new List<Product>();
    }
    private decimal money;

    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (!value.Equals(""))
            {
                this.name = value;
            }
            else
                throw new ArgumentException("Name cannot be empty");
        }

    }

    public void BuyProduct(Product product)
    {
        decimal currentMoney = this.money;

        if (currentMoney-product.Costs>=0)
        {
            currentMoney -= product.Costs;
            this.money = currentMoney;
            this.ProductBag.Add(product);

            Console.WriteLine($"{this.name} bought {product.Name}");


        }
        else
        {
            Console.WriteLine($"{this.name} can't afford {product.Name}");
        }

    }
    public decimal Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Money cannot be negative");
            else
                this.money = value;

        }
    }

    public List<Product> ProductBag { get; set; }
}

