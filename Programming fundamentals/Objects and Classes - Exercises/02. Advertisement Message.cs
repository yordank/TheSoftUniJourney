using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> Phrases = new List<string>();
            List<string> Events = new List<string>();
            List<string> Author = new List<string>();
            List<string> Cities = new List<string>();

            

            Phrases.Add("Excellent product.");
            Phrases.Add("Such a great product.");
            Phrases.Add("I always use that product.");
            Phrases.Add("Best product of its category.");
            Phrases.Add("Exceptional product.");
            Phrases.Add("I can’t live without this product.");
            

            Events.Add("I feel great!");
            Events.Add("Now I feel good.");
            Events.Add("I have succeeded with this product.");
            Events.Add("Makes miracles. I am happy of the results!");
            Events.Add("I cannot believe but now I feel awesome.");
            Events.Add("Try it yourself, I am very satisfied.");


            Author.Add("Diana");
            Author.Add("Petya");
            Author.Add("Stella");
            Author.Add("Elena");
            Author.Add("Katya");
            Author.Add("Iva");
            Author.Add("Annie");
            Author.Add("Eva");

            

            Cities.Add("Burgas");
            Cities.Add("Sofia");
            Cities.Add("Plovdiv");
            Cities.Add("Varna");
            Cities.Add("Ruse");

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Phrases[rnd.Next(0,Phrases.Count)]} {Events[rnd.Next(0, Events.Count)]} {Author[rnd.Next(0, Author.Count)]} - {Cities[rnd.Next(0, Cities.Count)]}");
            }

        }
    }
}
