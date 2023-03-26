CREATE TABLE [dbo].[Address]
(
	[Address_Id] INT NOT NULL PRIMARY KEY, 
    [Address1] NVARCHAR(50) NOT NULL, 
    [Address2] NVARCHAR(50) NULL, 
    [City_Id] INT NOT NULL, 
    [Apartment_Number] INT NULL, 
    [Postal_Code] NVARCHAR(10) NULL, 
    [Last_Update] DATETIME NOT NULL
)
