namespace _4_7_problems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstNameLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FirstName", c => c.String(nullable: true));
            AddColumn("dbo.Customers", "LastName", c => c.String(nullable: false, defaultValue: "Ivanov"));
            DropColumn("dbo.Customers", "Name", "Name");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "FirstName");
            DropColumn("dbo.Customers", "LastName");
            AddColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
