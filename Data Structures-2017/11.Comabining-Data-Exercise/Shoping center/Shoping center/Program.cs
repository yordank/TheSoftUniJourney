using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping_center
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            int n = int.Parse(Console.ReadLine());

            ShopingCenter shopingCenter = new ShopingCenter();

            //var input = Console.ReadLine();


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string command = input.Split()[0];

                input = input.Substring(input.IndexOf(' '));

                var items = input.Split(';').Select(x=>x.Trim()).ToList();

                switch (command)
                {
                    case "AddProduct":
                        shopingCenter.AddProduct(items[0],decimal.Parse(items[1]),items[2]);

                        break;
                    case "DeleteProducts":
                        if (items.Count == 1)
                            shopingCenter.DeleteByProducer(items[0]);
                        else
                            shopingCenter.DeleteByNameAndProducer(items[0], items[1]);
                        break;

                    case "FindProductsByName":
                        shopingCenter.FindProductsByName(items[0]);
                        break;
                    case "FindProductsByProducer":
                        shopingCenter.FindProductsByProducer(items[0]);
                        break;
                    case "FindProductsByPriceRange":
                        shopingCenter.FindProductsByPriceRangeFunc(decimal.Parse(items[0]), decimal.Parse(items[1]));
                        break;
                }

                
            }
            Console.WriteLine();

        }
    }
}
