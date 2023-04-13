CREATE PROCEDURE [dbo].[Color_Delete]
	@Color_Id int
AS
BEGIN
	DELETE [dbo].[Color]
	WHERE Color_Id = @Color_Id;
END
