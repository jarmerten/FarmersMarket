namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedregister : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserId", c => c.String());
            AddColumn("dbo.Farmers", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Farmers", "UserId");
            DropColumn("dbo.Customers", "UserId");
        }
    }
}
