﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.String());
            AlterColumn("dbo.Movies", "DateAdded", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
