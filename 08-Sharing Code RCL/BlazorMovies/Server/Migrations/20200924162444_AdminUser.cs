using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    public partial class AdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT[AspNetUsers] ON;
            INSERT INTO[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES(N'a729e84c-d741-4c50-99d8-f2f4e4ae38d2', 0, N'e73a3daf-c48e-4039-82c3-dad97cf23efb', N'gary@gmail.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'gary@gmail.com', N'gary@gmail.com', N'AQAAAAEAACcQAAAAEG8vRUyP44v2BilWjaALFT8Opc5tD99U7LGNloURTVSm/6wzHZrxxr7PKU0euOwZeA==', NULL, CAST(0 AS bit), N'0a83859f-a8f2-4b4b-a0b3-0a8b36e30109', CAST(0 AS bit), N'gary@gmail.com');
            IF EXISTS(SELECT* FROM [sys].[identity_columns] WHERE[name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND[object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT[AspNetUsers] OFF;

            GO

            IF EXISTS(SELECT * FROM[sys].[identity_columns] WHERE[name] IN(N'Id', N'ClaimType', N'ClaimValue', N'UserId') AND[object_id] = OBJECT_ID(N'[AspNetUserClaims]'))
    SET IDENTITY_INSERT[AspNetUserClaims] ON;
            INSERT INTO[AspNetUserClaims] ([Id], [ClaimType], [ClaimValue], [UserId])
VALUES(1, N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Admin', N'a729e84c-d741-4c50-99d8-f2f4e4ae38d2');
            IF EXISTS(SELECT* FROM [sys].[identity_columns] WHERE[name] IN (N'Id', N'ClaimType', N'ClaimValue', N'UserId') AND[object_id] = OBJECT_ID(N'[AspNetUserClaims]'))
    SET IDENTITY_INSERT[AspNetUserClaims] OFF;

            GO

            INSERT INTO[__EFMigrationsHistory]([MigrationId], [ProductVersion])
VALUES(N'20200924162444_AdminUser', N'3.1.8');

            GO

");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a729e84c-d741-4c50-99d8-f2f4e4ae38d2");
        }
    }
}
