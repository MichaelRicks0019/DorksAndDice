CREATE TABLE [dbo].[Orders]
(
	[Order_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Customer_Id] INT NOT NULL, 
    [ShoppingCart_Id] INT NOT NULL
)
