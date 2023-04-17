CREATE PROCEDURE [dbo].[Style_GetById]
		@Style_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Style]
	WHERE Style_Id = @Style_Id;
END
