namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0d3ef2b7-f310-4a1e-bc24-4036f29be029', N'admin@vidly.com', 0, N'AMuFHsvqO+kER365voVKBgo3Ai24KyZmuTHpstyaIXacoa5vikLkpVjiIrktwlbmbA==', N'2d9a2356-418e-4e50-a51c-05a7cee754bb', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'91a00d86-8da9-42cc-810c-adb20cafe51c', N'guest@vidly.com', 0, N'AJejGf8Mm36BsgFgR2z4zpWjafafzEa7gwai+yRvewD7L5xahGctMczi0kDdhskJ8g==', N'8d3896ea-fa9c-4da4-afe9-6c02424a2c05', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dcf9b1aa-f045-455e-8030-60f3458d4993', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0d3ef2b7-f310-4a1e-bc24-4036f29be029', N'dcf9b1aa-f045-455e-8030-60f3458d4993')
");
        }

        public override void Down()
        {
        }
    }
}
