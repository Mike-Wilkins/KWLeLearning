namespace KWLeLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCommentCounter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "KnowCount", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "WhatCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "WhatCount");
            DropColumn("dbo.Students", "KnowCount");
        }
    }
}
