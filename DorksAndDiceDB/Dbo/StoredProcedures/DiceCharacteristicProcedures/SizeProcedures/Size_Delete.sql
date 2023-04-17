CREATE PROCEDURE [dbo].[Size_Delete]
	@Size_Id int
AS
BEGIN
	DELETE [dbo].[Size]
	WHERE Size_Id = @Size_Id;
END
