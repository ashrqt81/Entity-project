namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.products", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.products", "name");
        }
    }
}
