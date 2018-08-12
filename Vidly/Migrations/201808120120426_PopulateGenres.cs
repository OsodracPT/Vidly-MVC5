namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "Genre");

            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action'),(2, 'Adventure'),(3, 'Comedy'),(4, 'Crime'),(5, 'Drama'),(6, 'Fantasy'),(7, 'Horror'),(8, 'Mystery'),(9, 'Romance'),(10, 'Science fiction'),(11, 'Thriller'),(12, 'Western')");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
