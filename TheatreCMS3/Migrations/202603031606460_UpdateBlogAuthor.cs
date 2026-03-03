namespace TheatreCMS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBlogAuthor : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BlogAuthors", "DisplayName");
            DropColumn("dbo.BlogAuthors", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogAuthors", "Email", c => c.String());
            AddColumn("dbo.BlogAuthors", "DisplayName", c => c.String());
        }
    }
}
