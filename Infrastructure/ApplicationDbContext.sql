IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018055939_addedCompanyTable'
)
BEGIN
    CREATE TABLE [CompanyCategores] (
        [Id] int NOT NULL IDENTITY,
        [Category] nvarchar(max) NULL,
        CONSTRAINT [PK_CompanyCategores] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018055939_addedCompanyTable'
)
BEGIN
    CREATE TABLE [Companies] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [CategoryId] int NOT NULL,
        CONSTRAINT [PK_Companies] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Companies_CompanyCategores_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [CompanyCategores] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018055939_addedCompanyTable'
)
BEGIN
    CREATE INDEX [IX_Companies_CategoryId] ON [Companies] ([CategoryId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018055939_addedCompanyTable'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20251018055939_addedCompanyTable', N'8.0.21');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018062834_addedJobAndPersonTables'
)
BEGIN
    CREATE TABLE [Job] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [RatePerHour] decimal(10,2) NOT NULL,
        CONSTRAINT [PK_Job] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018062834_addedJobAndPersonTables'
)
BEGIN
    CREATE TABLE [Person] (
        [Id] int NOT NULL IDENTITY,
        [SIN] nvarchar(450) NULL,
        [FirstName] nvarchar(50) NOT NULL,
        [LastName] nvarchar(50) NOT NULL,
        [DateOfBirth] datetime2 NOT NULL,
        [JobId] int NOT NULL,
        [CompanyId] int NOT NULL,
        CONSTRAINT [PK_Person] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Person_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Person_Job_JobId] FOREIGN KEY ([JobId]) REFERENCES [Job] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018062834_addedJobAndPersonTables'
)
BEGIN
    CREATE INDEX [IX_Person_CompanyId] ON [Person] ([CompanyId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018062834_addedJobAndPersonTables'
)
BEGIN
    CREATE INDEX [IX_Person_JobId] ON [Person] ([JobId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018062834_addedJobAndPersonTables'
)
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_Person_SIN] ON [Person] ([SIN]) WHERE [SIN] IS NOT NULL');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018062834_addedJobAndPersonTables'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20251018062834_addedJobAndPersonTables', N'8.0.21');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251018233624_personFluentAdded'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20251018233624_personFluentAdded', N'8.0.21');
END;
GO

COMMIT;
GO