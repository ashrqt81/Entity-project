namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.buddies",
                c => new
                    {
                        buddyId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        buddyType = c.Int(nullable: false),
                        phone = c.String(),
                        fax = c.String(),
                        mail = c.String(),
                        website = c.String(),
                    })
                .PrimaryKey(t => t.buddyId);
            
            CreateTable(
                "dbo.permissions",
                c => new
                    {
                        permissionId = c.Int(nullable: false, identity: true),
                        createdDate = c.DateTime(nullable: false),
                        empName = c.String(),
                        permissionType = c.Int(nullable: false),
                        number = c.Int(nullable: false),
                        StockId = c.Int(nullable: false),
                        buddyId = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.permissionId)
                .ForeignKey("dbo.buddies", t => t.buddyId, cascadeDelete: true)
                .ForeignKey("dbo.products", t => t.productId, cascadeDelete: true)
                .ForeignKey("dbo.stocks", t => t.StockId, cascadeDelete: true)
                .Index(t => t.StockId)
                .Index(t => t.buddyId)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        code = c.Int(nullable: false),
                        createddate = c.DateTime(nullable: false),
                        measureUnit = c.String(),
                        quantity = c.String(),
                        productionDate = c.DateTime(nullable: false),
                        expireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.productId);
            
            CreateTable(
                "dbo.productStocks",
                c => new
                    {
                        proStockId = c.Int(nullable: false, identity: true),
                        stockId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.proStockId)
                .ForeignKey("dbo.products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.stocks", t => t.stockId, cascadeDelete: true)
                .Index(t => t.stockId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.stocks",
                c => new
                    {
                        stockId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        createdDate = c.DateTime(nullable: false),
                        address = c.String(),
                        employeeName = c.String(),
                    })
                .PrimaryKey(t => t.stockId);
            
            CreateTable(
                "dbo.productTransfers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        stockId1 = c.Int(nullable: false),
                        stockId2 = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                        quantity = c.Double(nullable: false),
                        productionDate = c.DateTime(nullable: false),
                        expireDate = c.DateTime(nullable: false),
                        buddyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.buddies", t => t.buddyId, cascadeDelete: true)
                .ForeignKey("dbo.products", t => t.productId, cascadeDelete: true)
                .ForeignKey("dbo.stocks", t => t.stockId1, cascadeDelete: true)
                .Index(t => t.stockId1)
                .Index(t => t.productId)
                .Index(t => t.buddyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.permissions", "StockId", "dbo.stocks");
            DropForeignKey("dbo.permissions", "productId", "dbo.products");
            DropForeignKey("dbo.productStocks", "stockId", "dbo.stocks");
            DropForeignKey("dbo.productTransfers", "stockId1", "dbo.stocks");
            DropForeignKey("dbo.productTransfers", "productId", "dbo.products");
            DropForeignKey("dbo.productTransfers", "buddyId", "dbo.buddies");
            DropForeignKey("dbo.productStocks", "ProductId", "dbo.products");
            DropForeignKey("dbo.permissions", "buddyId", "dbo.buddies");
            DropIndex("dbo.productTransfers", new[] { "buddyId" });
            DropIndex("dbo.productTransfers", new[] { "productId" });
            DropIndex("dbo.productTransfers", new[] { "stockId1" });
            DropIndex("dbo.productStocks", new[] { "ProductId" });
            DropIndex("dbo.productStocks", new[] { "stockId" });
            DropIndex("dbo.permissions", new[] { "productId" });
            DropIndex("dbo.permissions", new[] { "buddyId" });
            DropIndex("dbo.permissions", new[] { "StockId" });
            DropTable("dbo.productTransfers");
            DropTable("dbo.stocks");
            DropTable("dbo.productStocks");
            DropTable("dbo.products");
            DropTable("dbo.permissions");
            DropTable("dbo.buddies");
        }
    }
}
