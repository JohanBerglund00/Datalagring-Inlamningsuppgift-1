CREATE TABLE [dbo].[Contact]
(
	[Id]       INT      NOT NULL IDENTITY,
    [Date]     DATETIME NOT NULL,
    [Customer] INT      NOT NULL,
    [Errand]   INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Contact_Customer] FOREIGN KEY ([Customer]) REFERENCES [dbo].[Customer] ([Id]),
    CONSTRAINT [FK_Contact_Errand] FOREIGN KEY ([Errand]) REFERENCES [dbo].[Errand] ([Id])
)
