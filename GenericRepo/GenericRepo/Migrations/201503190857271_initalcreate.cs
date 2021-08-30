namespace GenericRepo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initalcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Designation = c.String(),
                        Dept = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
