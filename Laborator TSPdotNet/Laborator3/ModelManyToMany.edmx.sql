
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/09/2020 22:06:10
-- Generated from EDMX file: C:\Users\Dorian\Documents\Facultate\TSP dotNET\Laborator TSPdotNet\ModelDesignFirst_L1\ModelManyToMany.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestPerson];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [AlbumId] int IDENTITY(1,1) NOT NULL,
    [AlbumName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Artists'
CREATE TABLE [dbo].[Artists] (
    [ArtistId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ArtistAlbum'
CREATE TABLE [dbo].[ArtistAlbum] (
    [Artists_ArtistId] int  NOT NULL,
    [Albums_AlbumId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AlbumId] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([AlbumId] ASC);
GO

-- Creating primary key on [ArtistId] in table 'Artists'
ALTER TABLE [dbo].[Artists]
ADD CONSTRAINT [PK_Artists]
    PRIMARY KEY CLUSTERED ([ArtistId] ASC);
GO

-- Creating primary key on [Artists_ArtistId], [Albums_AlbumId] in table 'ArtistAlbum'
ALTER TABLE [dbo].[ArtistAlbum]
ADD CONSTRAINT [PK_ArtistAlbum]
    PRIMARY KEY CLUSTERED ([Artists_ArtistId], [Albums_AlbumId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Artists_ArtistId] in table 'ArtistAlbum'
ALTER TABLE [dbo].[ArtistAlbum]
ADD CONSTRAINT [FK_ArtistAlbum_Artist]
    FOREIGN KEY ([Artists_ArtistId])
    REFERENCES [dbo].[Artists]
        ([ArtistId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Albums_AlbumId] in table 'ArtistAlbum'
ALTER TABLE [dbo].[ArtistAlbum]
ADD CONSTRAINT [FK_ArtistAlbum_Album]
    FOREIGN KEY ([Albums_AlbumId])
    REFERENCES [dbo].[Albums]
        ([AlbumId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistAlbum_Album'
CREATE INDEX [IX_FK_ArtistAlbum_Album]
ON [dbo].[ArtistAlbum]
    ([Albums_AlbumId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------