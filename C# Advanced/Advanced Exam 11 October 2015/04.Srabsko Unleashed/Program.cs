using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Srabsko_Unleashed
{
    public class SingerMoney
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
    }
    public class Venue
    {
        public string Name { get; set; }
        public List<SingerMoney> singerMoney { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Venue> venues = new List<Venue>();

            while (input!="End")
            {
                var match = Regex.Match(input, "([a-zA-Z| ]+)\\s@([a-zA-Z| ]+)\\s(\\d+)\\s(\\d+)");

                if (match.Success)
                {
                    string Venue = match.Groups[2].Value;
                    string Singer = match.Groups[1].Value;
                    decimal ticketPrice =decimal.Parse(match.Groups[3].Value);
                    decimal ticketsCount = decimal.Parse(match.Groups[4].Value);

                    if (venues.Where(x => x.Name == Venue).Count() == 0)
                    {
                        Venue newVenue = new Venue();
                        newVenue.Name = Venue;
                        SingerMoney newSinger = new SingerMoney();

                        newSinger.Name = Singer;
                        newSinger.Money = ticketPrice * ticketsCount;

                        newVenue.singerMoney = new List<SingerMoney>();
                        newVenue.singerMoney.Add(newSinger);

                        venues.Add(newVenue);


                    }
                    else
                    {
                        var venue = venues.Where(x => x.Name == Venue).First();

                        if (venue.singerMoney.Count(x => x.Name == Singer) > 0)
                        {
                            venue.singerMoney.Where(x => x.Name == Singer).First().Money += ticketPrice * ticketsCount;
                            venues.Where(x => x.Name == Venue).First().singerMoney.Where(x=>x.Name==Singer).First().Money = venue.singerMoney.Where(x => x.Name == Singer).First().Money;

                        }
                        else
                        {
                            SingerMoney newSingerMoney = new SingerMoney();
                            newSingerMoney.Name = Singer;
                            newSingerMoney.Money = ticketPrice * ticketsCount;

                            venue.singerMoney.Add(newSingerMoney);
                            venues.Where(x => x.Name == Venue).First().singerMoney= venue.singerMoney;

                        }


                    }

                }

                input = Console.ReadLine();
            }

            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Name);
                foreach (var singer in venue.singerMoney.OrderByDescending(x=>x.Money))
                {
                    Console.WriteLine($"#  {singer.Name} -> {singer.Money}");
                }
            }


        }
    }
}
