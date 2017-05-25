CREATE TABLE [dbo].[Person]
(
	[PersonId] INT NOT NULL Identity(1,1), 
    [FirstName] NVARCHAR(500) NOT NULL,
    [LastName] NVARCHAR(255) NOT NULL,
	[DateOfBirth] DATETIME2 NOT NULL, 
    CONSTRAINT [PK_Person] PRIMARY KEY ([PersonId])
)