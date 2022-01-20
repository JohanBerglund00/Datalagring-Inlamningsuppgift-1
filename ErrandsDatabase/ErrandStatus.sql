CREATE TABLE [dbo].[ErrandStatus]
(
	[Id]     INT           NOT NULL IDENTITY,
    [Status] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
