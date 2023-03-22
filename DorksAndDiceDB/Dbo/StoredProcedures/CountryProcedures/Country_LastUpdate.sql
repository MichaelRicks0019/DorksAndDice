CREATE PROCEDURE [dbo].[Country_LastUpdate]
	@Country_id int
AS
BEGIN
	SELECT Last_Update
	FROM [dbo].[Country]
	WHERE Country_Id = @Country_Id;
END
