CREATE TABLE [dbo].[Country]
(
	[Country_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Country_Name] NVARCHAR(50) NOT NULL, 
    [Last_Update] DATETIME NULL 
)
