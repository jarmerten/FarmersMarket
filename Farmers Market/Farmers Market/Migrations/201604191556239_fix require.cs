namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixrequire : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "CompanyName", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Farmers", "Email", c => c.String());
            AlterColumn("dbo.Farmers", "Address", c => c.String());
            AlterColumn("dbo.Farmers", "CompanyName", c => c.String());
            AlterColumn("dbo.Farmers", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
