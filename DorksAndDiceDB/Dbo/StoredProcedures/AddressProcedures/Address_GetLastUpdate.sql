CREATE PROCEDURE [dbo].[Address_GetLastUpdate]
	@Address_Id int
AS
BEGIN
	SELECT Last_Update
	FROM [dbo].[Address] 
	WHERE Address_Id = @Address_Id;
END
