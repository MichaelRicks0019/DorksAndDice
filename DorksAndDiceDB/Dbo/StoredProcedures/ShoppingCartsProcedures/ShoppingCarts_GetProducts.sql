CREATE PROCEDURE [dbo].[ShoppingCarts_GetProducts]
	@ShoppingCartId int
AS
BEGIN
	SELECT *
	FROM [dbo].[ShoppingCartItems]
	WHERE ShoppingCart_Id = @ShoppingCartId;
END
