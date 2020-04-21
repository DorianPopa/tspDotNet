
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 01:49:25
-- Generated from EDMX file: C:\Users\Dorian\Documents\Facultate\TSP dotNET\MyPhotos\MyPhotos\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FileFileProperty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileProperties] DROP CONSTRAINT [FK_FileFileProperty];
GO
IF OBJECT_ID(N'[dbo].[FK_PropertyFileProperty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileProperties] DROP CONSTRAINT [FK_PropertyFileProperty];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Files]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Files];
GO
IF OBJECT_ID(N'[dbo].[Properties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Properties];
GO
IF OBJECT_ID(N'[dbo].[FileProperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FileProperties];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [Deleted] bit  NOT NULL
);
GO

-- Creating table 'Properties'
CREATE TABLE [dbo].[Properties] (
    [Id] uniqueidentifier  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [IsBase] bit  NOT NULL
);
GO

-- Creating table 'FileProperties'
CREATE TABLE [dbo].[FileProperties] (
    [Id] uniqueidentifier  NOT NULL,
    [FileId] uniqueidentifier  NOT NULL,
    [PropertyId] uniqueidentifier  NOT NULL,
    [Value] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [PK_Properties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FileProperties'
ALTER TABLE [dbo].[FileProperties]
ADD CONSTRAINT [PK_FileProperties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FileId] in table 'FileProperties'
ALTER TABLE [dbo].[FileProperties]
ADD CONSTRAINT [FK_FileFileProperty]
    FOREIGN KEY ([FileId])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileFileProperty'
CREATE INDEX [IX_FK_FileFileProperty]
ON [dbo].[FileProperties]
    ([FileId]);
GO

-- Creating foreign key on [PropertyId] in table 'FileProperties'
ALTER TABLE [dbo].[FileProperties]
ADD CONSTRAINT [FK_PropertyFileProperty]
    FOREIGN KEY ([PropertyId])
    REFERENCES [dbo].[Properties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PropertyFileProperty'
CREATE INDEX [IX_FK_PropertyFileProperty]
ON [dbo].[FileProperties]
    ([PropertyId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------