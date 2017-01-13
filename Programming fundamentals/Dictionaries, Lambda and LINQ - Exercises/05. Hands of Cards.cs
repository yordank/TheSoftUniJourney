using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            
            while (input != "JOKER")
            {
                
                string[] NameAndValues = input.Trim().Split(':');

                 

                string Name = NameAndValues[0];

                var str = NameAndValues[1].Replace(" ", "");

                var Values = str.Split(',').ToList();

                 

                List<string> list = new List<string>();

                if (dict.ContainsKey(Name))
                {
                    

                    list = dict[Name];

                    foreach (var item in Values)
                    {
                        if(!list.Contains(item))
                        list.Add(item);
                    }

                     

                    dict[Name] = list;
                   

                }

                else
                {
                    
                    foreach (var item in Values)
                    {
                        if (!list.Contains(item))
                            list.Add(item);
                    }


                    dict.Add(Name, list);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {

              //  Console.WriteLine($"{item.Key}: {string.Join(" ",item.Value)}");
                Console.WriteLine($"{item.Key}: {CalculateValue(item.Value)}");
            }

           // foreach (var item in dict)
            //{
           //     Console.WriteLine($"{item.Key}: {item.Value}");
           // }


        }
        static int CalculateValue(List<string> Values)
        {
            int Power = 1;
            int type = 1;
            int w = Values[0].Count();
            int sum = 0;
            for (int i = 0; i < Values.Count(); i++)
            {

                string str = Values[i].Insert(Values[i].Count() - 1, " ");

                string []ValueType = str.Split(' ');


                string Value = ValueType[0];
                string Type = ValueType[1];


                if (Value == "J")
                    Power = 11;
                else
                if (Value == "Q")
                    Power = 12;
                else
                if (Value == "K")
                    Power = 13;
                else
                if (Value == "A")
                    Power = 14;
                else
                    Power = int.Parse(Value);

                if (Type == "S")
                    type = 4;

                if (Type == "H")
                    type = 3;

                if (Type == "D")
                    type = 2;

                if (Type == "C")
                    type = 1;

                sum += type * Power;
            }

            return sum;
        }
    }
}
