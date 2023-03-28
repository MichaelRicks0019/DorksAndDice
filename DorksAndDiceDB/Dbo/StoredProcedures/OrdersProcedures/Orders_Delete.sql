CREATE PROCEDURE [dbo].[Orders_Delete]
	@Order_Id int
AS
BEGIN
	DELETE [dbo].[Orders]
	WHERE Order_Id = @Order_Id;
END
