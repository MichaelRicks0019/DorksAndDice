CREATE PROCEDURE [dbo].[ShoppingCarts_GetByQuantity]
	@Quantity int
AS
BEGIN
	SELECT *
	FROM [dbo].[ShoppingCartItems]
	WHERE Quantity = @Quantity;
END

