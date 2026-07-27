
PS C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web> dotnet run
Using launch settings from C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web\Properties\launchSettings.json...
fail: Spark.Web.Program[0]
      An error occurred while seeding the database.
      System.InvalidOperationException: An error was generated for warning 'Microsoft.EntityFrameworkCore.Migrations.PendingModelChangesWarning': The model for context 'ApplicationDbContext' changes each time it is built. This is usually caused by dynamic values used in a 'HasData' call (e.g. `new DateTime()`, `Guid.NewGuid()`). Add a new migration and examine its contents to locate the cause, and replace the dynamic call with a static, hardcoded value. See https://aka.ms/efcore-docs-pending-changes. This exception can be suppressed or logged by passing event ID 'RelationalEventId.PendingModelChangesWarning' to the 'ConfigureWarnings' method in 'DbContext.OnConfiguring' or 'AddDbContext'.
         at Microsoft.EntityFrameworkCore.Diagnostics.EventDefinition`1.Log[TLoggerCategory](IDiagnosticsLogger`1 logger, TParam arg)
         at Microsoft.EntityFrameworkCore.Diagnostics.RelationalLoggerExtensions.NonDeterministicModel(IDiagnosticsLogger`1 diagnostics, Type contextType)
         at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.ValidateMigrations(Boolean useTransaction, String targetMigration)
         at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.Migrate(String targetMigration)
         at Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.Migrate(DatabaseFacade databaseFacade)
         at Spark.Web.Data.ApplicationDbInitializer.SeedAdmin(ApplicationDbContext context, UserManager`1 userManager, IConfiguration config) in C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web\Data\ApplicationDbInitializer.cs:line 17
         at Spark.Web.Program.Main(String[] args) in C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web\Program.cs:line 38
dbug: Microsoft.AspNetCore.SignalR.Internal.DefaultHubProtocolResolver[1]
      Registered SignalR Protocol: json, implemented by Microsoft.AspNetCore.SignalR.Protocol.JsonHubProtocol.
info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[63]
      User profile is available. Using 'C:\Users\Technicise Laptop 2\AppData\Local\ASP.NET\DataProtection-Keys' as key repository and Windows DPAPI to encrypt keys at rest.
warn: Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServer[8]
      The ASP.NET Core developer certificate is not trusted. For information about trusting the ASP.NET Core developer certificate, see https://aka.ms/aspnet/https-trust-dev-cert
Hosting environment: Development
Content root path: C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web
Now listening on: https://localhost:7001
Now listening on: http://localhost:7000
Application started. Press Ctrl+C to shut down.
PS C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web> dotnet run
Using launch settings from C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web\Properties\launchSettings.json...
info: Microsoft.EntityFrameworkCore.Migrations[20411]
      Acquiring an exclusive lock for migration application. See https://aka.ms/efcore-docs-migrations-lock for more information if this takes too long.
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (19ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT COUNT(*) FROM "sqlite_master" WHERE "name" = '__EFMigrationsLock' AND "type" = 'table';
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE IF NOT EXISTS "__EFMigrationsLock" (
          "Id" INTEGER NOT NULL CONSTRAINT "PK___EFMigrationsLock" PRIMARY KEY,
          "Timestamp" TEXT NOT NULL
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT OR IGNORE INTO "__EFMigrationsLock"("Id", "Timestamp") VALUES(1, '2026-07-27 12:54:56.5080592+00:00');
      SELECT changes();
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
          "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
          "ProductVersion" TEXT NOT NULL
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT COUNT(*) FROM "sqlite_master" WHERE "name" = '__EFMigrationsHistory' AND "type" = 'table';
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT "MigrationId", "ProductVersion"
      FROM "__EFMigrationsHistory"
      ORDER BY "MigrationId";
info: Microsoft.EntityFrameworkCore.Migrations[20402]
      Applying migration '20191101194423_Init'.
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE "AspNetRoles" (
          "Id" TEXT NOT NULL CONSTRAINT "PK_AspNetRoles" PRIMARY KEY,
          "Name" TEXT NULL,
          "NormalizedName" TEXT NULL,
          "ConcurrencyStamp" TEXT NULL
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE "AspNetUsers" (
          "Id" TEXT NOT NULL CONSTRAINT "PK_AspNetUsers" PRIMARY KEY,
          "UserName" TEXT NULL,
          "NormalizedUserName" TEXT NULL,
          "Email" TEXT NULL,
          "NormalizedEmail" TEXT NULL,
          "EmailConfirmed" INTEGER NOT NULL,
          "PasswordHash" TEXT NULL,
          "SecurityStamp" TEXT NULL,
          "ConcurrencyStamp" TEXT NULL,
          "PhoneNumber" TEXT NULL,
          "PhoneNumberConfirmed" INTEGER NOT NULL,
          "TwoFactorEnabled" INTEGER NOT NULL,
          "LockoutEnd" TEXT NULL,
          "LockoutEnabled" INTEGER NOT NULL,
          "AccessFailedCount" INTEGER NOT NULL
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE "AspNetRoleClaims" (
          "Id" INTEGER NOT NULL CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY AUTOINCREMENT,
          "RoleId" TEXT NOT NULL,
          "ClaimType" TEXT NULL,
          "ClaimValue" TEXT NULL,
          CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE "AspNetUserClaims" (
          "Id" INTEGER NOT NULL CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY AUTOINCREMENT,
          "UserId" TEXT NOT NULL,
          "ClaimType" TEXT NULL,
          "ClaimValue" TEXT NULL,
          CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE "AspNetUserLogins" (
          "LoginProvider" TEXT NOT NULL,
          "ProviderKey" TEXT NOT NULL,
          "ProviderDisplayName" TEXT NULL,
          "UserId" TEXT NOT NULL,
          CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey"),
          CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE "AspNetUserRoles" (
          "UserId" TEXT NOT NULL,
          "RoleId" TEXT NOT NULL,
          CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId"),
          CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE,
          CONSTRAINT "FK_AspNetUserRoles_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE "AspNetUserTokens" (
          "UserId" TEXT NOT NULL,
          "LoginProvider" TEXT NOT NULL,
          "Name" TEXT NOT NULL,
          "Value" TEXT NULL,
          CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
          CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
      );
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO "AspNetRoles" ("Id", "ConcurrencyStamp", "Name", "NormalizedName")
      VALUES ('453e564a-29b5-4f1f-b49b-1bd116778fce', '38c23849-bc6b-451e-bba0-c817703d3168', 'Admin', 'ADMIN');
      SELECT changes();
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON "AspNetRoleClaims" ("RoleId");
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX "IX_AspNetUserClaims_UserId" ON "AspNetUserClaims" ("UserId");
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX "IX_AspNetUserLogins_UserId" ON "AspNetUserLogins" ("UserId");
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX "IX_AspNetUserRoles_RoleId" ON "AspNetUserRoles" ("RoleId");
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE INDEX "EmailIndex" ON "AspNetUsers" ("NormalizedEmail");
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
      VALUES ('20191101194423_Init', '9.0.7');
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (5ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      DELETE FROM "__EFMigrationsLock";
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (6ms) [Parameters=[@__normalizedEmail_0='?' (Size = 15)], CommandType='Text', CommandTimeout='30']
      SELECT "a"."Id", "a"."AccessFailedCount", "a"."ConcurrencyStamp", "a"."Email", "a"."EmailConfirmed", "a"."LockoutEnabled", "a"."LockoutEnd", "a"."NormalizedEmail", "a"."NormalizedUserName", "a"."PasswordHash", "a"."PhoneNumber", "a"."PhoneNumberConfirmed", "a"."SecurityStamp", "a"."TwoFactorEnabled", "a"."UserName"
      FROM "AspNetUsers" AS "a"
      WHERE "a"."NormalizedEmail" = @__normalizedEmail_0
      LIMIT 2
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@__normalizedUserName_0='?' (Size = 15)], CommandType='Text', CommandTimeout='30']
      SELECT "a"."Id", "a"."AccessFailedCount", "a"."ConcurrencyStamp", "a"."Email", "a"."EmailConfirmed", "a"."LockoutEnabled", "a"."LockoutEnd", "a"."NormalizedEmail", "a"."NormalizedUserName", "a"."PasswordHash", "a"."PhoneNumber", "a"."PhoneNumberConfirmed", "a"."SecurityStamp", "a"."TwoFactorEnabled", "a"."UserName"
      FROM "AspNetUsers" AS "a"
      WHERE "a"."NormalizedUserName" = @__normalizedUserName_0
      LIMIT 1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[@p0='?' (Size = 36), @p1='?' (DbType = Int32), @p2='?' (Size = 36), @p3='?' (Size = 15), @p4='?' (DbType = Boolean), @p5='?' (DbType = Boolean), @p6='?' (DbType = DateTimeOffset), @p7='?' (Size = 15), @p8='?' (Size = 15), @p9='?' (Size = 84), @p10='?', @p11='?' (DbType = Boolean), @p12='?' (Size = 32), @p13='?' (DbType = Boolean), @p14='?' (Size = 15)], CommandType='Text', CommandTimeout='30']
      INSERT INTO "AspNetUsers" ("Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName")
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14);
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@__normalizedRoleName_0='?' (Size = 5)], CommandType='Text', CommandTimeout='30']
      SELECT "a"."Id", "a"."ConcurrencyStamp", "a"."Name", "a"."NormalizedName"
      FROM "AspNetRoles" AS "a"
      WHERE "a"."NormalizedName" = @__normalizedRoleName_0
      LIMIT 2
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@__p_0='?' (Size = 36), @__p_1='?' (Size = 36)], CommandType='Text', CommandTimeout='30']
      SELECT "a"."UserId", "a"."RoleId"
      FROM "AspNetUserRoles" AS "a"
      WHERE "a"."UserId" = @__p_0 AND "a"."RoleId" = @__p_1
      LIMIT 1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@__normalizedRoleName_0='?' (Size = 5)], CommandType='Text', CommandTimeout='30']
      SELECT "a"."Id", "a"."ConcurrencyStamp", "a"."Name", "a"."NormalizedName"
      FROM "AspNetRoles" AS "a"
      WHERE "a"."NormalizedName" = @__normalizedRoleName_0
      LIMIT 2
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@__normalizedUserName_0='?' (Size = 15)], CommandType='Text', CommandTimeout='30']
      SELECT "a"."Id", "a"."AccessFailedCount", "a"."ConcurrencyStamp", "a"."Email", "a"."EmailConfirmed", "a"."LockoutEnabled", "a"."LockoutEnd", "a"."NormalizedEmail", "a"."NormalizedUserName", "a"."PasswordHash", "a"."PhoneNumber", "a"."PhoneNumberConfirmed", "a"."SecurityStamp", "a"."TwoFactorEnabled", "a"."UserName"
      FROM "AspNetUsers" AS "a"
      WHERE "a"."NormalizedUserName" = @__normalizedUserName_0
      LIMIT 1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@p0='?' (Size = 36), @p1='?' (Size = 36)], CommandType='Text', CommandTimeout='30']
      INSERT INTO "AspNetUserRoles" ("RoleId", "UserId")
      VALUES (@p0, @p1);
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@p14='?' (Size = 36), @p0='?' (DbType = Int32), @p1='?' (Size = 36), @p15='?' (Size = 36), @p2='?' (Size = 15), @p3='?' (DbType = Boolean), @p4='?' (DbType = Boolean), @p5='?' (DbType = DateTimeOffset), @p6='?' (Size = 15), @p7='?' (Size = 15), @p8='?' (Size = 84), @p9='?', @p10='?' (DbType = Boolean), @p11='?' (Size = 32), @p12='?' (DbType = Boolean), @p13='?' (Size = 15)], CommandType='Text', CommandTimeout='30']
      UPDATE "AspNetUsers" SET "AccessFailedCount" = @p0, "ConcurrencyStamp" = @p1, "Email" = @p2, "EmailConfirmed" = @p3, "LockoutEnabled" = @p4, "LockoutEnd" = @p5, "NormalizedEmail" = @p6, "NormalizedUserName" = @p7, "PasswordHash" = @p8, "PhoneNumber" = @p9, "PhoneNumberConfirmed" = @p10, "SecurityStamp" = @p11, "TwoFactorEnabled" = @p12, "UserName" = @p13
      WHERE "Id" = @p14 AND "ConcurrencyStamp" = @p15
      RETURNING 1;
dbug: Microsoft.AspNetCore.SignalR.Internal.DefaultHubProtocolResolver[1]
      Registered SignalR Protocol: json, implemented by Microsoft.AspNetCore.SignalR.Protocol.JsonHubProtocol.
info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[63]
      User profile is available. Using 'C:\Users\Technicise Laptop 2\AppData\Local\ASP.NET\DataProtection-Keys' as key repository and Windows DPAPI to encrypt keys at rest.
warn: Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServer[8]
      The ASP.NET Core developer certificate is not trusted. For information about trusting the ASP.NET Core developer certificate, see https://aka.ms/aspnet/https-trust-dev-cert
Hosting environment: Development
Content root path: C:\githubrepos\sayan801\spark-dotnet-fhir-server\src\Spark.Web
Now listening on: https://localhost:7001
Now listening on: http://localhost:7000
Application started. Press Ctrl+C to shut down.
