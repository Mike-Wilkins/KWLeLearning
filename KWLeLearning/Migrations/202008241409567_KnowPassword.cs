namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KnowPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Knows", "KnowPassword", c => c.String());
            DropColumn("dbo.Knows", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Knows", "Password", c => c.String());
            DropColumn("dbo.Knows", "KnowPassword");
        }
    }
}
