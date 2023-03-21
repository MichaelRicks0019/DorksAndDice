CREATE PROCEDURE [dbo].[Address_GetById]
	@Address_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[Address] 
	WHERE Address_Id = @Address_Id;
END
