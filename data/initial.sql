CREATE DATABASE Todo;
GO

USE Todo;
GO


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

CREATE TABLE [TodoTasks] (
    [Id] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NULL,
    [Status] int NULL,
    CONSTRAINT [PK_TodoTasks] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240621231821_initialcreate', N'7.0.4');
GO

COMMIT;
GO

