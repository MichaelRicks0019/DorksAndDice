CREATE PROCEDURE [dbo].[Address_GetByAddress2]
	@Address2 nvarchar(75)
AS
BEGIN
	SELECT *
	FROM [dbo].[Address] 
	WHERE Address2 = @Address2;
END
