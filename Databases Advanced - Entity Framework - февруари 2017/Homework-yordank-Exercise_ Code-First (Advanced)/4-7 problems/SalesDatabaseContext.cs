namespace _4_7_problems
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Migrations;

    public partial class SalesDatabaseContext : DbContext
    {
        public SalesDatabaseContext()
            : base("name=SalesDatabaseContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SalesDatabaseContext,Configuration>());
           

        }


        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<StoreLocation> StoreLocations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Sales)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customer_Id);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sales)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Product_Id);

            modelBuilder.Entity<StoreLocation>()
                .HasMany(e => e.Sales)
                .WithOptional(e => e.StoreLocation)
                .HasForeignKey(e => e.StoreLocation_Id);
        }
    }
}
