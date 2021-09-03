namespace UniversityRating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Universities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Universities", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Universities", new[] { "CountryId" });
            DropIndex("dbo.Universities", new[] { "CategoryId" });
            DropTable("dbo.Universities");
            DropTable("dbo.Countries");
            DropTable("dbo.Categories");
        }
    }
}
