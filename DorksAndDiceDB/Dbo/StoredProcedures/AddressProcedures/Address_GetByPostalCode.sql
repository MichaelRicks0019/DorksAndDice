CREATE PROCEDURE [dbo].[Address_GetByPostalCode]
	@Postal_Code nvarchar(25)
AS
BEGIN
	SELECT *
	FROM [dbo].[Address] 
	WHERE Postal_Code = @Postal_Code;
END
