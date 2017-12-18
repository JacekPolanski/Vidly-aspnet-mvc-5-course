namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemebershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MemebershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MemebershipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MemebershipTypes SET Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
