CREATE PROCEDURE [dbo].[Color_GetById]
	@Color_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Color]
	WHERE Color_Id = @Color_Id;
END
