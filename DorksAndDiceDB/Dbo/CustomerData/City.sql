CREATE TABLE [dbo].[City]
(
	[City_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Country_Id] INT NULL, 
    [City_Name] NVARCHAR(50) NULL, 
    [State_Name] NVARCHAR(50) NULL, 
    [Last_Update] DATETIME NULL
)
