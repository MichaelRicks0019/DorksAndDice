CREATE PROCEDURE [dbo].[ShoppingCarts_Update]
	@Customer_Id int,
	@ShoppingCart_Id int,
	@Product_Id int,
	@Quantity int
AS
BEGIN
	UPDATE [dbo].[ShoppingCartItems]
	SET ShoppingCart_Id = @ShoppingCart_Id, 
	Product_Id = @Product_Id, 
	Quantity = @Quantity
	WHERE Customer_Id = @Customer_Id AND ShoppingCart_Id = ShoppingCart_Id AND Product_Id = @Product_Id;
END
