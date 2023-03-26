CREATE PROCEDURE [dbo].[Product_Delete]
	@Product_Id int
AS
BEGIN
	DELETE [dbo].[Product]
	WHERE Product_Id = @Product_Id;
END