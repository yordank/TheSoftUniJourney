using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Cat_Lady
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Cat> cats = new Dictionary<string, Cat>();

            var input = Console.ReadLine();

            while(input!="End")
            {
                var items = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (items[0])
                {
                    case "Siamese":
                        Siamese siameseCat = new Siamese(items[1], int.Parse(items[2]));
                        cats.Add(items[1], siameseCat);
                        break;
                    case "Cymric":
                        Cymric cymricCat= new Cymric(items[1], double.Parse(items[2]));
                        cats.Add(items[1], cymricCat);
                        break;
                    case "StreetExtraordinaire":
                        StreetExtraordinaire streetCat = new StreetExtraordinaire(items[1], int.Parse(items[2]));
                        cats.Add(items[1], streetCat);
                        break;
                }

                input = Console.ReadLine();
            }

            var catName = Console.ReadLine();

            if(cats.ContainsKey(catName))
            Console.WriteLine(cats[catName].ToString());
            else
                Console.WriteLine();

        }
    }
}
