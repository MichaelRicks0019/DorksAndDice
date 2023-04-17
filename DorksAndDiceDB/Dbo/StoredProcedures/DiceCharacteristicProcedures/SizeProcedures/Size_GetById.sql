CREATE PROCEDURE [dbo].[Size_GetById]
	@Size_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[Size]
	WHERE Size_Id = @Size_Id;
END
