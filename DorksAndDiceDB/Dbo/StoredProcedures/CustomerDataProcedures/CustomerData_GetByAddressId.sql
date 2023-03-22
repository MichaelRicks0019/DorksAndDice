CREATE PROCEDURE [dbo].[CustomerData_GetByAddressId]
	@Address_Id int
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE Address_Id = @Address_Id;
END
