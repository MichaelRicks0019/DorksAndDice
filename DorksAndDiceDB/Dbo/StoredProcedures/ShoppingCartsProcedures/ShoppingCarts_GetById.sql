CREATE PROCEDURE [dbo].[ShoppingCarts_GetById]
	@Customer_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[ShoppingCartItems]
	WHERE Customer_Id = @Customer_Id;
END

