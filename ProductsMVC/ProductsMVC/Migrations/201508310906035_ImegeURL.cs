namespace ProductsMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImegeURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImegeURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImegeURL");
        }
    }
}
