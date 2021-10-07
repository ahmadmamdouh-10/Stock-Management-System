namespace DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Quantity", c => c.Int(nullable: false));
        }
    }
}
