CREATE PROCEDURE [dbo].[Product_GetById]
	@Product_Id nvarchar(MAX)
AS
BEGIN
	SELECT *
	FROM Product
	WHERE Product_Id = @Product_Id;
END
