CREATE TABLE [dbo].[ContactsErrands]
(
	[ContactId] INT NOT NULL , 
    [ErrandsId] INT NOT NULL, 
    PRIMARY KEY ([ContactId], [ErrandsId]), 
    CONSTRAINT [FK_ContactsErrands_ToContacts] FOREIGN KEY ([ContactId]) REFERENCES [Contacts]([Id]), 
    CONSTRAINT [FK_ContactsErrands_ToErrands] FOREIGN KEY ([ErrandsId]) REFERENCES [Errands]([Id]), 
)

GO
