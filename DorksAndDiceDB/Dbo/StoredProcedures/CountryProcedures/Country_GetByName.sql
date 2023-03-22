CREATE PROCEDURE [dbo].[Country_GetByName]
	@Country_Name nvarchar(50)
AS
BEGIN
	SELECT * 
	FROM [dbo].[Country]
	WHERE Country_Name = @Country_Name;
END
