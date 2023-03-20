CREATE PROCEDURE [dbo].[Address_GetByAddress1]
	@Address1 nvarchar(75)
AS
BEGIN
	SELECT *
	FROM [dbo].[Address] 
	WHERE Address1 = @Address1;
END
