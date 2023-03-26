CREATE PROCEDURE [dbo].[Product_GetByType]
	@Product_Type nvarchar(50)
AS
BEGIN
	SELECT *
	FROM Product
	WHERE Product_Type = @Product_Type;
END
