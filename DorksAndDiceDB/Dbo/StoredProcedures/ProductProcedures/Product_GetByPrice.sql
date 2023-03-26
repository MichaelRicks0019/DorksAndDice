CREATE PROCEDURE [dbo].[Product_GetByPrice]
	@Product_Price decimal(18,0)
AS
BEGIN
	SELECT *
	FROM Product
	WHERE Product_Price = @Product_Price;
END
