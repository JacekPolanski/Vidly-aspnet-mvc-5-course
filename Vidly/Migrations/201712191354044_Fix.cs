namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies ALTER COLUMN ReleaseDate DATETIME NULL");
            Sql("ALTER TABLE Movies ALTER COLUMN DateAdded DATETIME NULL");
        }
        
        public override void Down()
        {
        }
    }
}
