namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5ee5a2ae-0201-4b92-9ef9-1a61f0f2cfc9', N'admin1@vidly.com', 0, N'ADiP9OMZs6bTL5qsbWY06zXHp3yosyxd5kezPvL9pS8i6KtiHcSbAaGyyX2hoqKeCA==', N'51168dbc-5f98-4b26-8f69-dc65c483bd71', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b36240c2-6c4a-494d-a397-6266fcb4e45f', N'guest@vidly.com', 0, N'AC3EKV7sLcc04yvB+6PSirZu19LeEzgtvtJM6jZBHEMZ5Qt/edmSYelThPFitgR8SQ==', N'8888b1fd-f57e-4ad8-bb3b-ef66f6a3ff8a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'74d0023f-abfc-449f-8f4e-cb13f355a70a', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5ee5a2ae-0201-4b92-9ef9-1a61f0f2cfc9', N'74d0023f-abfc-449f-8f4e-cb13f355a70a')");
        }
        
        public override void Down()
        {
        }
    }
}
