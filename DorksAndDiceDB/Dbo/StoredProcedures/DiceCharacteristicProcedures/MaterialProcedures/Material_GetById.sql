CREATE PROCEDURE [dbo].[Material_GetById]
	@Material_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[Material]
	WHERE Material_Id = @Material_Id;
END
