CREATE PROCEDURE [dbo].[CustomerData_Delete]
	@Customer_Id int
AS
BEGIN
	DELETE [dbo].[CustomerData]
	WHERE Customer_Id = @Customer_Id;
END
