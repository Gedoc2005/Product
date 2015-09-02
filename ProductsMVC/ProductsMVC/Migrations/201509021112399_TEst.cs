namespace ProductsMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TEst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            AddColumn("dbo.Products", "ImageURL", c => c.String());
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Products", "ImegeURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ImegeURL", c => c.String());
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropColumn("dbo.Products", "CategoryId");
            DropColumn("dbo.Products", "ImageURL");
            DropTable("dbo.Categories");
        }
    }
}
