CREATE PROCEDURE [dbo].[Product_GetByQuantity]
	@Product_Quantity int
AS
BEGIN
	SELECT *
	FROM Product
	WHERE Product_Quantity = @Product_Quantity;
END
