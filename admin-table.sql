CREATE TABLE [dbo].[admin] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [email]    VARCHAR (50) NULL,
    [password] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);