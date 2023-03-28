CREATE PROCEDURE [dbo].[Orders_Update]
	@Order_Id int,
	@Customer_Id int,
	@ShoppingCart_Id int
AS
BEGIN
	UPDATE [dbo].[Orders]
	SET Customer_Id = @Customer_Id, ShoppingCart_Id = @ShoppingCart_Id;
END
