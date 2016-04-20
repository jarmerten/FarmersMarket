namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jhk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        ItemId = c.String(nullable: false, maxLength: 128),
                        CartId = c.String(),
                        Quantity = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Product_ProductID = c.Int(nullable: false),
                        Product_ProductName = c.String(nullable: false, maxLength: 100),
                        Product_Description = c.String(nullable: false),
                        Product_ImagePath = c.String(),
                        Product_UnitPrice = c.Double(),
                        Product_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId);
            
            DropTable("dbo.Produces");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Produces",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Quanity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.CartItems");
        }
    }
}
