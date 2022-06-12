CREATE TABLE [dbo].[Products] (
    [Id]    INT          NOT NULL,
    [Name]  VARCHAR (50) DEFAULT ((5)) NULL,
    [Price] MONEY        NULL,
    [Stock] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

