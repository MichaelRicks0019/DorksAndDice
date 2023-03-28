CREATE PROCEDURE [dbo].[ShoppingCarts_GetByProductId]
	@Product_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[ShoppingCartItems]
	WHERE Product_Id = @Product_Id;
END

