CREATE PROCEDURE [dbo].[CustomerData_GetCreateDate]
	@CustomerId int
AS
BEGIN
	SELECT Create_Date
	FROM CustomerData
	WHERE Customer_Id = @CustomerId;
END
