CREATE TABLE [dbo].[ShoppingCartItems]
(
	[Customer_Id] INT NOT NULL PRIMARY KEY, 
    [ShoppingCart_Id] INT NOT NULL, 
    [Product_Id] INT NOT NULL, 
    [Quantity] NCHAR(10) NULL
)
