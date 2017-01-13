using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> MaterialQuantity = new Dictionary<string, int>();
            Dictionary<string, int> JunkedQuantity = new Dictionary<string, int>();


            MaterialQuantity.Add("shards",0);
            MaterialQuantity.Add("fragments", 0);
            MaterialQuantity.Add("motes", 0);


            int flag = 1;
            int check = 1;
            while (flag == 1)
            {
                string input = Console.ReadLine();
                string[] items = input.Split();

                for (int i = 0; i < items.Length; i=i+2)
                {
                    int quatity = int.Parse(items[i]);
                    string material = items[i + 1].ToLower();

                    if (material == "shards" || material == "motes" || material == "fragments")
                    {
                        if (MaterialQuantity.ContainsKey(material))
                        {
                            MaterialQuantity[material] += quatity;

                        }
                        else
                        {
                            MaterialQuantity.Add(material, quatity);
                        }

                        if (checkReachedLimit(MaterialQuantity)&&check==1)
                        {
                            print(MaterialQuantity);
                            check = 0;
                            flag = 0;
                            break;
                        }
                    }

                    else
                    {
                        if (JunkedQuantity.ContainsKey(material))
                        {
                            JunkedQuantity[material] += quatity;
                        }
                        else
                        {
                            JunkedQuantity.Add(material, quatity);
                        }

                    }

                }
            }

            var t = new Dictionary<string, int>();

            foreach (var item in MaterialQuantity)
            {
                if (item.Value >= 250)
                    t.Add(item.Key, item.Value - 250);

                else
                    t.Add(item.Key, item.Value);

               
            }

            var newMaterialQuantityDictionary = t.OrderBy(y=>y.Key).OrderBy(x => -x.Value);

            
            foreach (var item in newMaterialQuantityDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var JunkedDictionary= JunkedQuantity.OrderBy(x => x.Key);

            foreach (var item in JunkedDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
        static bool checkReachedLimit(Dictionary<string,int>dict)
        {
            foreach (var item in dict)
            {
                if (item.Key == "shards" || item.Key == "fragments" || item.Key == "motes")
                {
                    if (item.Value >= 250)
                     return true; 
                }
            }
            return false;
        }
        static void print(Dictionary<string, int> dict)
        {
            

            foreach (var item in dict)
            {
                if (item.Value >= 250)
                {
                    if (item.Key == "shards")
                        Console.WriteLine("Shadowmourne obtained!");

                    if (item.Key == "fragments")
                        Console.WriteLine("Valanyr obtained!");

                    if (item.Key == "motes")
                        Console.WriteLine("Dragonwrath obtained!");

                   
                   
                }

                
            }

             
        }

        
    }
}
