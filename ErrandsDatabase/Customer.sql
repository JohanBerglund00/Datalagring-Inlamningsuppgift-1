CREATE TABLE [dbo].[Customer]
(
	[Id]        INT           NOT NULL IDENTITY,
    [FirstName] NVARCHAR (50) NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
    [Address]   NVARCHAR (50) NULL,
    [PostCode]  NVARCHAR (10) NULL,
    [City]      NVARCHAR (50) NULL,
    [Email]     NVARCHAR (50) NULL,
    [Phone]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
