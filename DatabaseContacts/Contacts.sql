CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(75) NOT NULL, 
    [PhoneNumber] NVARCHAR(25) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [PostalCode] NVARCHAR(10) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL
)
