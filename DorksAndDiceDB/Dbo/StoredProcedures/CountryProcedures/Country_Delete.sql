CREATE PROCEDURE [dbo].[Country_Delete]
	@Country_Id int
AS
BEGIN
	DELETE [dbo].[Country]
	WHERE Country_Id = @Country_Id;
END

