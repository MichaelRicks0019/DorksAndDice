CREATE PROCEDURE [dbo].[Product_GetByName]
	@Product_Name nvarchar(MAX)
AS
BEGIN
	SELECT *
	FROM Product
	WHERE Product_Name = @Product_Name;
END
