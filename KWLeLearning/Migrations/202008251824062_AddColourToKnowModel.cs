namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColourToKnowModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Colour", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Colour");
        }
    }
}
