namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColourKnow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Knows", "KnowColour", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Knows", "KnowColour");
        }
    }
}
