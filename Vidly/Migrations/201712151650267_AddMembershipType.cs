namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemebershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MemebershipType_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MemebershipType_Id");
            AddForeignKey("dbo.Customers", "MemebershipType_Id", "dbo.MemebershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemebershipType_Id", "dbo.MemebershipTypes");
            DropIndex("dbo.Customers", new[] { "MemebershipType_Id" });
            DropColumn("dbo.Customers", "MemebershipType_Id");
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MemebershipTypes");
        }
    }
}
