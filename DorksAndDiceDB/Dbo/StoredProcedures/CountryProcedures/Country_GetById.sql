CREATE PROCEDURE [dbo].[Country_GetById]
	@Country_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Country]
	WHERE Country_Id = @Country_Id;
END
