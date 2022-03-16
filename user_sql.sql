CREATE TABLE [dbo].[user] (
    [Id]             INT           NOT NULL IDENTITY,
    [account_number] NUMERIC (18)  NULL,
    [name]           VARCHAR (255) NULL,
    [address]        VARCHAR (255) NULL,
    [account_type]   int foreign key references account_types,
    [balance] NUMERIC(18, 2) NULL, 
    [aadhar_card] NUMERIC(16) NULL, 
    [password] VARCHAR(255) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

