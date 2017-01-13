using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _5.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
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
                    ReleaseDate = DateTime.ParseExact(input[3],"dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = decimal.Parse(input[5])
                };


                BooksReaded.Add(Ith_book);

            }

            library.books = BooksReaded;

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);


            var p = library.books.Where(x => x.ReleaseDate > date);
                


            foreach (var item in p.OrderBy(x=>x.Title).OrderBy(x => x.ReleaseDate))
            {
                Console.WriteLine($"{item.Title} -> {item.ReleaseDate.ToString("dd.MM.yyyy")}");
            }



        }
    }
}
