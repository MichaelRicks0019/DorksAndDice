CREATE PROCEDURE [dbo].[CustomerData_GetById]
	@Customer_Id int
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE Customer_Id = @Customer_Id
END
