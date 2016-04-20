namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcustomers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Farmers", "CompanyName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Farmers", "CompanyName");
            DropTable("dbo.Customers");
        }
    }
}
