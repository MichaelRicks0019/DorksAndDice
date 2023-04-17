CREATE PROCEDURE [dbo].[Edge_Delete]
	@Edge_Id int
AS
BEGIN
	DELETE [dbo].[Edge]
	WHERE Edge_Id = @Edge_Id;
END
