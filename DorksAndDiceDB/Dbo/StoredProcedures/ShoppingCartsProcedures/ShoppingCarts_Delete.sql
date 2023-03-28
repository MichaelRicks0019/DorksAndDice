CREATE PROCEDURE [dbo].[ShoppingCarts_Delete]
	@Customer_Id int
AS
BEGIN
	DELETE [dbo].[ShoppingCartItems]
	WHERE Customer_Id = @Customer_Id;
END
