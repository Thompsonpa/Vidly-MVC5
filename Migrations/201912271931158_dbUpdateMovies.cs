namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbUpdateMovies : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Genrestype_Id", newName: "GenreID_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_Genrestype_Id", newName: "IX_GenreID_Id");
            DropColumn("dbo.Movies", "GenreID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreID", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Movies", name: "IX_GenreID_Id", newName: "IX_Genrestype_Id");
            RenameColumn(table: "dbo.Movies", name: "GenreID_Id", newName: "Genrestype_Id");
        }
    }
}
