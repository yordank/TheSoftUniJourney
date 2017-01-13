using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
            
    }
    class Library
    {
        public List<Book> books { get; set; }
        public string Name { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Library library = new Library();
            library.Name = "The Library";
            List<Book> BooksReaded = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                Book Ith_book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = input[3],
                    ISBN =input[4],
                    Price =decimal.Parse(input[5])
                };


                BooksReaded.Add(Ith_book);
                
            }

            library.books = BooksReaded;


            var p = library.books.
                GroupBy(x => x.Author).
                Select
                (
                g => new 
                {
                    Name = g.Key,
                    Price=g.Sum(x=>x.Price)
                } 
                );


            foreach (var item in p.OrderBy(x=>x.Name).OrderBy(y=>-y.Price))
            {
                Console.WriteLine($"{item.Name} -> {item.Price:f2}");
            }



        }
    }
}
