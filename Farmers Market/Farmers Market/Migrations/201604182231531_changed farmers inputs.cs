namespace Farmers_Market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedfarmersinputs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farmers", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Farmers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Farmers", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Farmers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Farmers", "Email", c => c.String());
            AlterColumn("dbo.Farmers", "Password", c => c.String());
            AlterColumn("dbo.Farmers", "Address", c => c.String());
            DropColumn("dbo.Farmers", "ConfirmPassword");
        }
    }
}
