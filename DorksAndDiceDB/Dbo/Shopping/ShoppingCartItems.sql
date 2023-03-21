CREATE TABLE [dbo].[ShoppingCartItems]
(
	[Customer_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShoppingCart_Id] INT NOT NULL, 
    [Product_Id] INT NOT NULL, 
    [Quantity] INT NOT NULL
)
