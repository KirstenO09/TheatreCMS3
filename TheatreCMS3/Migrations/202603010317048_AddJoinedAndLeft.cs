namespace TheatreCMS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJoinedAndLeft : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogAuthors", "Joined", c => c.DateTime(nullable: false));
            AddColumn("dbo.BlogAuthors", "Left", c => c.DateTime());
            DropColumn("dbo.BlogAuthors", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogAuthors", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.BlogAuthors", "Left");
            DropColumn("dbo.BlogAuthors", "Joined");
        }
    }
}
