namespace StudentRegistrationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        photo = c.Binary(),
                        firstName = c.String(nullable: false, maxLength: 255),
                        fatherName = c.String(nullable: false, maxLength: 255),
                        grandFatherName = c.String(nullable: false, maxLength: 255),
                        age = c.Int(nullable: false),
                        gender = c.String(nullable: false, maxLength: 255),
                        bio = c.String(),
                        region = c.String(maxLength: 255),
                        city = c.String(nullable: false, maxLength: 255),
                        subcity = c.String(nullable: false, maxLength: 255),
                        woreda = c.Int(nullable: false),
                        houseNo = c.String(maxLength: 255),
                        phoneNo = c.String(nullable: false),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
