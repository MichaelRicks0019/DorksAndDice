CREATE PROCEDURE [dbo].[Address_Delete]
	@Address_Id int
AS
BEGIN
	DELETE FROM [dbo].[Address]
	WHERE Address_Id = @Address_Id;
END
