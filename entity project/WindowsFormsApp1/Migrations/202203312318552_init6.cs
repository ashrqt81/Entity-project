namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.productStocks", "quantity", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.productStocks", "quantity");
        }
    }
}
