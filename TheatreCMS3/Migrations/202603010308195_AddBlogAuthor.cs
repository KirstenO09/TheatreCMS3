namespace TheatreCMS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogAuthor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogAuthors",
                c => new
                    {
                        BlogAuthorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DisplayName = c.String(),
                        Bio = c.String(),
                        Email = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BlogAuthorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogAuthors");
        }
    }
}
