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

CREATE TABLE [Stores] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Street] nvarchar(max) NULL,
    [Number] nvarchar(max) NULL,
    [Addition] nvarchar(max) NULL,
    [Zipcode] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [isFranchiseStore] bit NOT NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Persons] (
    [ID] int NOT NULL IDENTITY,
    [StoreID] int NOT NULL,
    [LastName] nvarchar(max) NULL,
    [FirstName] nvarchar(max) NULL,
    [Gender] int NOT NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Persons_Stores_StoreID] FOREIGN KEY ([StoreID]) REFERENCES [Stores] ([ID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Persons_StoreID] ON [Persons] ([StoreID]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211029084251_InitialMigration', N'5.0.11');
GO

COMMIT;
GO

