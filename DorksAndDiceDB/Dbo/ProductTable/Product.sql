CREATE TABLE [dbo].[Product]
(
	[Product_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product_Name] NVARCHAR(MAX) NULL, 
    [Product_Quantity] INT NULL, 
    [Product_Price] DECIMAL NULL, 
    [Product_Type] NVARCHAR(50) NULL
)
