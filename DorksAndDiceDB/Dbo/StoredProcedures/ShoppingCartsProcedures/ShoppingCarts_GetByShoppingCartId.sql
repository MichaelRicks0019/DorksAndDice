CREATE PROCEDURE [dbo].[ShoppingCarts_GetByShoppingCartId]
	@ShoppingCart_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[ShoppingCartItems]
	WHERE ShoppingCart_Id = @ShoppingCart_Id;
END
