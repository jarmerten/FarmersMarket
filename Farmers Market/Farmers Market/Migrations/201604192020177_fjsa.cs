namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fjsa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produces",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        ImagePath = c.String(),
                        UnitPrice = c.Double(),
                        CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateIndex("dbo.CartItems", "ProductId");
            AddForeignKey("dbo.CartItems", "ProductId", "dbo.Produces", "ProductID", cascadeDelete: true);
            DropColumn("dbo.CartItems", "Product_ProductID");
            DropColumn("dbo.CartItems", "Product_ProductName");
            DropColumn("dbo.CartItems", "Product_Description");
            DropColumn("dbo.CartItems", "Product_ImagePath");
            DropColumn("dbo.CartItems", "Product_UnitPrice");
            DropColumn("dbo.CartItems", "Product_CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CartItems", "Product_CategoryID", c => c.Int());
            AddColumn("dbo.CartItems", "Product_UnitPrice", c => c.Double());
            AddColumn("dbo.CartItems", "Product_ImagePath", c => c.String());
            AddColumn("dbo.CartItems", "Product_Description", c => c.String(nullable: false));
            AddColumn("dbo.CartItems", "Product_ProductName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.CartItems", "Product_ProductID", c => c.Int(nullable: false));
            DropForeignKey("dbo.CartItems", "ProductId", "dbo.Produces");
            DropIndex("dbo.CartItems", new[] { "ProductId" });
            DropTable("dbo.Produces");
        }
    }
}
