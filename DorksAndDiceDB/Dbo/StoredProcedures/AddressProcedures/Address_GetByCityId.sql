CREATE PROCEDURE [dbo].[Address_GetByCityId]
	@City_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[Address] 
	WHERE City_Id = @City_Id;
END
