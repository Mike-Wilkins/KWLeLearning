namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentRequiredValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Firstname", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Team", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Team", c => c.String());
            AlterColumn("dbo.Students", "Password", c => c.String());
            AlterColumn("dbo.Students", "Username", c => c.String());
            AlterColumn("dbo.Students", "Surname", c => c.String());
            AlterColumn("dbo.Students", "Firstname", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
        }
    }
}
