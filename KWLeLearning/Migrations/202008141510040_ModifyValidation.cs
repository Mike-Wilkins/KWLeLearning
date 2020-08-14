namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Username", c => c.String());
            AlterColumn("dbo.Students", "Password", c => c.String());
            AlterColumn("dbo.Students", "Team", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Team", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
        }
    }
}
