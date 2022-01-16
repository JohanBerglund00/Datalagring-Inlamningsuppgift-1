CREATE TABLE [dbo].[Errands]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Status] INT NOT NULL, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [DateCreated] DATETIME NOT NULL, 
    [DateChanged] DATETIME NULL, 
    CONSTRAINT [FK_Errands_ToErrandsStatus] FOREIGN KEY ([Status]) REFERENCES [ErrandsStatus]([Id])
)
