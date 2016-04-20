namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfarmer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Farmers",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    Name = c.Int(nullable: false),
                    Address = c.String(),
                    Password = c.String(),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.id);

        }
        
        public override void Down()
        {
           DropTable("dbo.Farmers");
        }
    }
}
