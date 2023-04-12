CREATE PROCEDURE [dbo].[ShoppingCarts_ClearCart]
	@ShoppingCart_Id int
AS
BEGIN
	DELETE [dbo].[ShoppingCartItems]
	WHERE ShoppingCart_Id = @ShoppingCart_Id;
END
