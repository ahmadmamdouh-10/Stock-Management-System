namespace DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cat_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Cat_ID, cascadeDelete: true)
                .Index(t => t.Cat_ID);
            
            CreateTable(
                "dbo.ExportItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Stock_ID = c.Int(nullable: false),
                        Item_ID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_ID, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID, cascadeDelete: true)
                .Index(t => t.Stock_ID)
                .Index(t => t.Item_ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ImportItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Stock_ID = c.Int(nullable: false),
                        Item_ID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_ID, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID, cascadeDelete: true)
                .Index(t => t.Stock_ID)
                .Index(t => t.Item_ID);
            
            CreateTable(
                "dbo.ItemInStocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item_ID = c.Int(),
                        Stock_ID = c.Int(),
                        OverAllQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_ID)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Stock_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemInStocks", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.ItemInStocks", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.ImportItems", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.ImportItems", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.ExportItems", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.ExportItems", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.Items", "Cat_ID", "dbo.Categories");
            DropIndex("dbo.ItemInStocks", new[] { "Stock_ID" });
            DropIndex("dbo.ItemInStocks", new[] { "Item_ID" });
            DropIndex("dbo.ImportItems", new[] { "Item_ID" });
            DropIndex("dbo.ImportItems", new[] { "Stock_ID" });
            DropIndex("dbo.ExportItems", new[] { "Item_ID" });
            DropIndex("dbo.ExportItems", new[] { "Stock_ID" });
            DropIndex("dbo.Items", new[] { "Cat_ID" });
            DropTable("dbo.ItemInStocks");
            DropTable("dbo.ImportItems");
            DropTable("dbo.Stocks");
            DropTable("dbo.ExportItems");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
