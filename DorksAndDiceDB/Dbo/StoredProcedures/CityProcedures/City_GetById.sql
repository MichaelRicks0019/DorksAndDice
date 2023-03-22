CREATE PROCEDURE [dbo].[City_GetById]
	@City_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[City]
	WHERE City_Id = @City_Id;
END
