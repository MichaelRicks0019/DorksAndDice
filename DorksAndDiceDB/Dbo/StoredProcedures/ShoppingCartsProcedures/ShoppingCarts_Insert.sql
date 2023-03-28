CREATE PROCEDURE [dbo].[ShoppingCarts_Insert]
	@Customer_Id int,
	@ShoppingCart_Id int,
	@Product_Id int,
	@Quantity int
AS
BEGIN
	INSERT INTO [dbo].[ShoppingCartItems] (ShoppingCart_Id, 
	Product_Id, 
	Quantity)
	VALUES (@ShoppingCart_Id, 
	@Product_Id, 
	@Quantity);
END
