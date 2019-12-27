namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genrestype_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Genrestype_Id");
            AddForeignKey("dbo.Movies", "Genrestype_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genrestype_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genrestype_Id" });
            DropColumn("dbo.Movies", "Genrestype_Id");
        }
    }
}
