CREATE PROCEDURE [dbo].[CustomerData_LastLoggedOn]
	@CustomerId int
AS
BEGIN
	SELECT Last_Logged_On
	FROM CustomerData
	WHERE Customer_Id = @CustomerId;
END
