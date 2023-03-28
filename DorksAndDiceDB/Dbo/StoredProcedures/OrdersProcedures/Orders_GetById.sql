CREATE PROCEDURE [dbo].[Orders_GetById]
	@Order_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Orders]
	WHERE Order_Id = @Order_Id;
END
