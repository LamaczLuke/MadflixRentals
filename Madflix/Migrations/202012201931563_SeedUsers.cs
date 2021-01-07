namespace Madflix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1509bbe8-4e94-4522-9537-a3fd4b0988e2', N'admin@madflix.com', 0, N'ACQe5Wr9Z811oEsRm0vzF7AEab7Z+SjcIT5bRGOQAQ9ifN9D5fhgXu6eKRyK8n/dhg==', N'705b2b64-f791-4a7b-b899-87c63f6eb76f', NULL, 0, 0, NULL, 1, 0, N'admin@madflix.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a4a008e-eeca-4517-8a39-1bcd2ec04995', N'guest@madflix.com', 0, N'ANTXvgcJHTGowmF6acTARIuC/wrJHx4AxATRxPbUmULwEDsrL5MZoiMcOLdyBnpGvg==', N'db9fb9e2-bc5b-464b-81b6-92db594b9bd8', NULL, 0, 0, NULL, 1, 0, N'guest@madflix.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'72e78612-387a-4dcb-b819-41d69cd5aa28', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1509bbe8-4e94-4522-9537-a3fd4b0988e2', N'72e78612-387a-4dcb-b819-41d69cd5aa28')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
