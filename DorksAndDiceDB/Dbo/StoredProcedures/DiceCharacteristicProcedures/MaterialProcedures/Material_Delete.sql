CREATE PROCEDURE [dbo].[Material_Delete]
	@Material_Id int
AS
BEGIN
	DELETE [dbo].[Material]
	WHERE Material_Id = @Material_Id;
END
