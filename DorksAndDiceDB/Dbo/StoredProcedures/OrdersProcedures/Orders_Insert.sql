CREATE PROCEDURE [dbo].[Orders_Insert]
	@Order_Id int,
	@Customer_Id int,
	@ShoppingCart_Id int
AS
BEGIN
	INSERT INTO [dbo].[Orders] (Customer_Id, ShoppingCart_Id)
	VALUES (@Customer_Id, @ShoppingCart_Id);
END
