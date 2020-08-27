namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamToKnowCommentdb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Knows", "Team", c => c.String());
            DropColumn("dbo.Knows", "KnowCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Knows", "KnowCount", c => c.Int(nullable: false));
            DropColumn("dbo.Knows", "Team");
        }
    }
}
