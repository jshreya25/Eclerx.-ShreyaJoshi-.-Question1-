namespace Test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Password = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        MobileNumber = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registrations");
        }
    }
}
