CREATE PROCEDURE [dbo].[CustomerData_GetByPhoneNumbert]
	@Phone_Number nvarchar(15)
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE Phone_Number = @Phone_Number
END
