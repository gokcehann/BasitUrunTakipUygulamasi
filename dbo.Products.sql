CREATE TABLE [dbo].[Products] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [ProductName] VARCHAR (50) NOT NULL,
    [UnitPrice]   MONEY        NOT NULL,
    [Stock]       INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

