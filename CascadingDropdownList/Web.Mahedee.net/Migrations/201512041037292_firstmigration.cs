namespace Web.Mahedee.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Products", "Item_Id", "dbo.Items");
            DropIndex("dbo.Categories", new[] { "Item_Id" });
            DropIndex("dbo.Products", new[] { "Item_Id" });
            CreateIndex("dbo.Items", "CategoryId");
            CreateIndex("dbo.Items", "ProductId");

            AddForeignKey("dbo.Items", "CategoryId", "dbo.Categories", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Items", "ProductId", "dbo.Products", "Id", cascadeDelete: false);

            DropColumn("dbo.Categories", "Item_Id");
            DropColumn("dbo.Products", "Item_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Item_Id", c => c.Int());
            AddColumn("dbo.Categories", "Item_Id", c => c.Int());
            DropForeignKey("dbo.Items", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Items", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "ProductId" });
            DropIndex("dbo.Items", new[] { "CategoryId" });
            CreateIndex("dbo.Products", "Item_Id");
            CreateIndex("dbo.Categories", "Item_Id");
            AddForeignKey("dbo.Products", "Item_Id", "dbo.Items", "Id");
            AddForeignKey("dbo.Categories", "Item_Id", "dbo.Items", "Id");
        }
    }
}
