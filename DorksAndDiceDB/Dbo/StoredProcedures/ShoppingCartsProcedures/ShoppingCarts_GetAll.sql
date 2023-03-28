CREATE PROCEDURE [dbo].[ShoppingCarts_GetAll]
AS
BEGIN
	SELECT *
	FROM [dbo].[ShoppingCartItems];
END

