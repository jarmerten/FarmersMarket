namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class namesastring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Farmers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Farmers", "Name", c => c.Int(nullable: false));
        }
    }
}
