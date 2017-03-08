namespace _4_7_problems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesAddDateDefault : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sales", "Date", s => s.DateTime(defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "Date", s => s.DateTime(defaultValueSql: "NULL"));
        }
    }
}
