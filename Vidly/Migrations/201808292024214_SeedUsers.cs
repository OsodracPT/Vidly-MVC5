namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5ba5efd7-a8d8-439a-867f-0b5a5b9cf23f', N'admin@vidly.com', 0, N'AOSIIEq5N3/ZCs0pc+IdOplIo3UCO8RYxk2WLDjwCfGi+yKbNCgediFMe9vWboDVxA==', N'd0ac7212-a138-44cf-9a2a-ee4e6d7d9822', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8291b516-12bc-4d1d-af0a-c1bcd8c45a8c', N'guest@vidly.com', 0, N'AMjod8Ja7YYiHc2nZPnJIOJskp5SmOm/dQq8EulJLIw9izH2sCDosrYWBkNc6Pb1+A==', N'bd32c796-9c8d-44ae-8b60-67758a971b8c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9ab5f35c-6f1b-4411-a462-93b8e1d51111', N'administrador@vidly.com', 0, N'AHFDYE+DVEzBJqpxHgCKMqsPXLC4Bz80K1EZOXgBJy7lK0DjPBMRZw6XNva++Mtlzw==', N'50bf5ef2-3b15-4af6-821c-5e2a1a7d570b', NULL, 0, 0, NULL, 1, 0, N'administrador@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c833153b-642d-449c-842a-266e02d551ee', N'CanManageMovie')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f9b32bce-e99b-4263-b255-6f141e42474a', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ab5f35c-6f1b-4411-a462-93b8e1d51111', N'f9b32bce-e99b-4263-b255-6f141e42474a')

");
        }
        
        public override void Down()
        {
        }
    }
}
