CREATE PROCEDURE [dbo].[City_GetByName]
	@City_Name nvarchar(50)
AS
BEGIN
	SELECT *
	FROM [dbo].[City]
	WHERE City_Name = @City_Name;	
END
