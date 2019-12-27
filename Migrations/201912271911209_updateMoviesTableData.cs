namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMoviesTableData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreID,ReleaseDate,DateAdded,NumberInStock) VALUES ('Hangover',4,'04/23/2008', '12/27/1019', 8)");
            Sql("INSERT INTO Movies (Name,GenreID,ReleaseDate,DateAdded,NumberInStock) VALUES ('Die Hard',2,'01/15/2000', '12/27/1019', 5)");
            Sql("INSERT INTO Movies (Name,GenreID,ReleaseDate,DateAdded,NumberInStock) VALUES ('The Terminator',2,'08/15/1991', '12/27/1019', 10)");
            Sql("INSERT INTO Movies (Name,GenreID,ReleaseDate,DateAdded,NumberInStock) VALUES ('Toy Story',24,'06/26/1995', '12/27/1019', 15)");
            Sql("INSERT INTO Movies (Name,GenreID,ReleaseDate,DateAdded,NumberInStock) VALUES ('Titanic',16,'02/06/1985', '12/27/1019', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
