namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenresId", newName: "GenreId");
            RenameIndex(table: "dbo.Movies", name: "IX_GenresId", newName: "IX_GenreId");
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId", newName: "IX_GenresId");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "GenresId");
        }
    }
}
