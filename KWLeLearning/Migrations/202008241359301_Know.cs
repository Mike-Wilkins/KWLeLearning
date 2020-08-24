namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Know : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Knows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        KnowComment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Knows");
        }
    }
}
