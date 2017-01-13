using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, BigInteger>> dict = new Dictionary<string, Dictionary<string, BigInteger>>();



            while (input != "End")
            {

                string[] items = input.Split('@');

                if (items.Count() == 2)
                {
                    string SingerName = items[0];

                    string[] VanuePriceTickets = items[1].Split();

                    string[] SingerNameParts = SingerName.Split();

                    //if (VanuePriceTickets.Count() >= 3 && VanuePriceTickets.Count() <= 5 && SingerNameParts.Count()>=1 && SingerNameParts.Count()<=4)
                    {
                        // if (checkVanuePriceTickes(VanuePriceTickets))
                        {
                            int VanuePriceTickesCounter = VanuePriceTickets.Count();
                            string Vanue = "";

                            if (VanuePriceTickesCounter <= 5 && VanuePriceTickesCounter >= 3)
                            {
                                for (int i = 0; i < VanuePriceTickesCounter - 2; i++)
                                {
                                    Vanue += VanuePriceTickets[i];
                                    if (i != VanuePriceTickesCounter - 3)
                                        Vanue += " ";
                                }

                                int Price;//=int.Parse(VanuePriceTickets[VanuePriceTickesCounter - 2]);
                                int Tickets;//=int.Parse(VanuePriceTickets[VanuePriceTickesCounter - 1]);
                                bool a = int.TryParse(VanuePriceTickets[VanuePriceTickesCounter - 2], out Price);
                                bool b = int.TryParse(VanuePriceTickets[VanuePriceTickesCounter - 1], out Tickets);

                                if (a && b && SingerName[SingerName.Length - 1] == ' ')
                                {
                                    BigInteger Money = Price * Tickets;

                                    if (dict.ContainsKey(Vanue))
                                    {
                                        Dictionary<string, BigInteger> Singers = new Dictionary<string, BigInteger>();

                                        Singers = dict[Vanue];

                                        if (Singers.ContainsKey(SingerName))
                                        {
                                            Singers[SingerName] += Money;
                                        }
                                        else
                                        {
                                            Singers.Add(SingerName, Money);
                                        }

                                        dict[Vanue] = Singers;

                                    }
                                    else
                                    {
                                        Dictionary<string, BigInteger> Singers = new Dictionary<string, BigInteger>();
                                        Singers.Add(SingerName, Money);
                                        dict.Add(Vanue, Singers);
                                    }
                                }
                            }
                        }

                    }

                }

                input = Console.ReadLine();
            }

            foreach (var dictPair in dict)
            {
                Console.WriteLine(dictPair.Key);

                var Singers = dictPair.Value.OrderBy(x => -x.Value);
                foreach (var SingerPair in Singers)
                {
                    Console.WriteLine($"#  {SingerPair.Key}-> {SingerPair.Value}");
                }
            }


        }
        static bool checkVanuePriceTickes(string[] VanuePriceTickets)
        {

            int count = VanuePriceTickets.Count();

            //   if (count >= 3)
            {
                decimal a1;
                decimal a2;
                bool isPriceCorrent = decimal.TryParse(VanuePriceTickets[count - 1], out a1);
                bool isTicketsCorrect = decimal.TryParse(VanuePriceTickets[count - 2], out a2);


                if (isPriceCorrent && isTicketsCorrect)
                {

                    return true;

                }
            }

            return false;
        }
    }
}
