using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Karaoke
    {
        public string Name { get; set; }
        public List<SongAwards> songsawards { get; set; }
        public int AwardCount { get; set; }
        public List<string> AwardNames { get; set; }
    }

    class SongAwards
    {
        public string SongName { get; set; }
        public List<string>Awards { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Karaoke> karaokes = new List<Karaoke>();

            var names = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            for (int i = 0; i < names.Count(); i++)
            {
                Karaoke newKaraoke = new Karaoke();

                newKaraoke.Name = names[i].Trim();

                newKaraoke.songsawards = new List<SongAwards>();

                newKaraoke.AwardCount = 0;

                newKaraoke.AwardNames = new List<string>();

                karaokes.Add(newKaraoke);
            }

            var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            string input = Console.ReadLine();

            while (input != "dawn")
            {
                var items = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                string name = items[0].Trim();
                string song = items[1].Trim();
                string award = items[2].Trim();

                if (songs.Where(x => x == song).Count() > 0 && names.Where(x => x == name).Count() > 0)
                {

                    if (karaokes.Where(x => x.Name == name).First().songsawards.Where(x => x.SongName == song).Count() == 0)
                    {
                        SongAwards s = new SongAwards();
                        s.SongName = song;
                        s.Awards = new List<string>();
                        s.Awards.Add(award);
                        karaokes.Where(x => x.Name == name).First().songsawards.Add(s);
                        karaokes.Where(x => x.Name == name).First().AwardCount++;
                        karaokes.Where(x => x.Name == name).First().AwardNames.Add(award);

                    }

                    else
                    {
                        int counts = karaokes.Where(x => x.Name == name).First().songsawards.Where(x => x.SongName == song).First().Awards.Distinct().Count();
                        karaokes.Where(x => x.Name == name).First().songsawards.Where(x=>x.SongName==song).First().Awards.Add(award);

                        int c = karaokes.Where(x => x.Name == name).First().songsawards.Where(x => x.SongName == song).First().Awards.Distinct().Count();

                        if (c > counts)
                        {
                            karaokes.Where(x => x.Name == name).First().AwardCount++;
                            karaokes.Where(x => x.Name == name).First().AwardNames.Add(award);
                        }
                    }

                  
                   
                }

                input = Console.ReadLine();
            }

            int a = 5;
            
            int flag = 0;
            foreach (var item in karaokes.OrderByDescending(x => x.AwardCount).ThenBy(x => x.Name))
            {
                if (item.AwardCount > 0)
                    Console.WriteLine($"{item.Name}: {item.AwardCount} awards");

                foreach (var award in item.AwardNames.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("No awards");
              

        }
    }
}
