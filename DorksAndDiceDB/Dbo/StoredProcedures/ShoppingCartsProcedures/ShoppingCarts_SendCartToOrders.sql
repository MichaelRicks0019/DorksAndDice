CREATE PROCEDURE [dbo].[ShoppingCarts_SendCartToOrders]
	@ShoppingCart_Id int
AS 
BEGIN
	INSERT INTO [dbo].[Orders] (Customer_Id, ShoppingCart_Id)
	VALUES ((SELECT Customer_Id, ShoppingCart_Id
	FROM [dbo].[ShoppingCartItems]
	WHERE ShoppingCart_Id = @ShoppingCart_Id));
END
