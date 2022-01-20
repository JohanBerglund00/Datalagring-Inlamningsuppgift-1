CREATE TABLE [dbo].[Errand]
(
	[Id]          INT            NOT NULL IDENTITY,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [Status]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Errand_ErrandStatus] FOREIGN KEY ([Status]) REFERENCES [dbo].[ErrandStatus] ([Id])
);
