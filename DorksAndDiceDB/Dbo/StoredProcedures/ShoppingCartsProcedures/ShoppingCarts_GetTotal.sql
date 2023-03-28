CREATE PROCEDURE [dbo].[ShoppingCarts_GetTotal]
	@ShoppingCart_Id int
AS
BEGIN
	SELECT MAX(p.Product_Price * s.Quantity)
	FROM [dbo].[ShoppingCartItems] s JOIN [dbo].[Product] p
	ON (s.Customer_Id = p.Product_Id)
	WHERE ShoppingCart_Id = @ShoppingCart_Id;
END
