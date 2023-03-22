CREATE PROCEDURE [dbo].[City_Delete]
	@City_Id int
AS
BEGIN
	DELETE [dbo].[City]
	WHERE City_Id = @City_Id;
END
