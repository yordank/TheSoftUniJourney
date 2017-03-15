namespace BookShopSystem.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookShopContext : DbContext
    {
        
        public BookShopContext()
            : base("name=BookShopContext")
        {
            
            Database.SetInitializer (new DropCreateDatabaseIfModelChanges<BookShopContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(x => x.RelatedBooks)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("bookId");
                    m.MapRightKey("relatedId");
                    m.ToTable("RelatedTable");
                });
                
            base.OnModelCreating(modelBuilder);
        }


         public virtual DbSet<Book> Books { get; set; }
         public virtual DbSet<Author> Authors { get; set; }
         public virtual DbSet<Category> Categories { get; set; }


    }

  
}