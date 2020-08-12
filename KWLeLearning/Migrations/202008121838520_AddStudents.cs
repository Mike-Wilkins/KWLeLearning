namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Surname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Team = c.String(),
                        IsLoggedIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
