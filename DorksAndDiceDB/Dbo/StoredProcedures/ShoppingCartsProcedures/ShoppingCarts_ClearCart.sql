CREATE PROCEDURE [dbo].[ShoppingCarts_ClearCart]
	@ShoppingCartId int
AS
BEGIN
	DELETE [dbo].[ShoppingCartItems]
	WHERE ShoppingCart_Id = @ShoppingCartId;
END
