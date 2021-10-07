﻿namespace DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
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
                "dbo.ItemInStocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item_ID = c.Int(),
                        Stock_ID = c.Int(),
                        Date = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Items", t => t.Item_ID)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Stock_ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemInStocks", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.ItemInStocks", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.Items", "Cat_ID", "dbo.Categories");
            DropIndex("dbo.ItemInStocks", new[] { "Stock_ID" });
            DropIndex("dbo.ItemInStocks", new[] { "Item_ID" });
            DropIndex("dbo.Items", new[] { "Cat_ID" });
            DropTable("dbo.Stocks");
            DropTable("dbo.ItemInStocks");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
