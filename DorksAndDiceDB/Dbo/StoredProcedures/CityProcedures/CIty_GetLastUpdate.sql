CREATE PROCEDURE [dbo].[CIty_GetLastUpdate]
	@City_Id int
AS
BEGIN
	SELECT Last_Update
	FROM [dbo].[City]
	WHERE City_Id = @City_Id;
END
