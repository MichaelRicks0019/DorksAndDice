CREATE PROCEDURE [dbo].[Style_Delete]
	@Style_Id int
AS
BEGIN
	DELETE [dbo].[Style]
	WHERE Style_Id = @Style_Id;
END
