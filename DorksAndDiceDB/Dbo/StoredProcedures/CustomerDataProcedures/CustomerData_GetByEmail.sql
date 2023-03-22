CREATE PROCEDURE [dbo].[CustomerData_GetByEmail]
	@Email nvarchar(75)
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE Email = @Email;
END
