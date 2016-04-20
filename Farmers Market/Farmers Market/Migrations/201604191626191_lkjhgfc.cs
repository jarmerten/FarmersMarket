namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lkjhgfc : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CompanyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CompanyName", c => c.String());
        }
    }
}
