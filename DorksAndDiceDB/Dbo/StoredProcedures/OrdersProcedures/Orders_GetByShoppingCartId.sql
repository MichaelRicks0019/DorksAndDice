CREATE PROCEDURE [dbo].[Orders_GetByShoppingCartId]
	@ShoppingCart_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Orders]
	WHERE ShoppingCart_Id= @ShoppingCart_Id;
END