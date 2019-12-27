namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMoviesTableColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "GenreID", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.String(nullable: false));          
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "GenreID", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
    }
}
