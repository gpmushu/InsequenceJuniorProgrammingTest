
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/13/2019 11:31:58
-- Generated from EDMX file: C:\Users\Justin\source\repos\InsequenceJuniorProgrammingTest\InsequenceJuniorProgrammingTest\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ShipmentEntryDB];
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

-- Creating table 'ShipmentTables'
CREATE TABLE [dbo].[ShipmentTables] (
    [ShipmentID] int IDENTITY(1,1) NOT NULL,
    [SiteName] nvarchar(max)  NULL,
    [ContainerTable_ContainerID] int  NOT NULL
);
GO

-- Creating table 'ContainerTables'
CREATE TABLE [dbo].[ContainerTables] (
    [ContainerID] int IDENTITY(1,1) NOT NULL,
    [ShipmentID] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ShipmentID] in table 'ShipmentTables'
ALTER TABLE [dbo].[ShipmentTables]
ADD CONSTRAINT [PK_ShipmentTables]
    PRIMARY KEY CLUSTERED ([ShipmentID] ASC);
GO

-- Creating primary key on [ContainerID] in table 'ContainerTables'
ALTER TABLE [dbo].[ContainerTables]
ADD CONSTRAINT [PK_ContainerTables]
    PRIMARY KEY CLUSTERED ([ContainerID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ContainerTable_ContainerID] in table 'ShipmentTables'
ALTER TABLE [dbo].[ShipmentTables]
ADD CONSTRAINT [FK_ContainerTableShipmentTable]
    FOREIGN KEY ([ContainerTable_ContainerID])
    REFERENCES [dbo].[ContainerTables]
        ([ContainerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContainerTableShipmentTable'
CREATE INDEX [IX_FK_ContainerTableShipmentTable]
ON [dbo].[ShipmentTables]
    ([ContainerTable_ContainerID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------