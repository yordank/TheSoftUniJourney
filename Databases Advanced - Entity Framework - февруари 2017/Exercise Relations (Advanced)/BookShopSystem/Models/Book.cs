using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSystem.Models
{
    public enum EditionType
    {
        Normal,
        Promo,
        Gold
    }
    public enum AgeRestriction
    {
        Minor,
        Teen,
        Adult
    }
    public class Book
    {
        public Book()
        {
            this.Categories = new HashSet<Category>();
            this.RelatedBooks = new HashSet<Book>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50),MinLength(1)]
        public string  Title { get; set; }

        [MaxLength(1000)]
        public string  Description { get; set; }

        public EditionType Edition { get; set; }

        public decimal Price { get; set; }
        [Range(0,int.MaxValue)]
        public int Copies { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<Category> Categories{get;set;} 

        public virtual ICollection<Book> RelatedBooks { get; set; }


    }
}
