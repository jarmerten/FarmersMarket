namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madethingsnotrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Password", c => c.String(maxLength: 100));
            AlterColumn("dbo.Farmers", "Name", c => c.String());
            AlterColumn("dbo.Farmers", "CompanyName", c => c.String());
            AlterColumn("dbo.Farmers", "Address", c => c.String());
            AlterColumn("dbo.Farmers", "Email", c => c.String());
            AlterColumn("dbo.Farmers", "Password", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Farmers", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Farmers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "CompanyName", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
        }
    }
}
