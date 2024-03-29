﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableUpdate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenreID_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_GenreID_Id", newName: "IX_Genre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreID_Id");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreID_Id");
        }
    }
}
