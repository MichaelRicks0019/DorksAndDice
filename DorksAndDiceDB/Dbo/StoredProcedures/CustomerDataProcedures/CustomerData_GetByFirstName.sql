CREATE PROCEDURE [dbo].[CustomerData_GetByFirstName]
	@First_Name nvarchar(50)
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE First_Name = @First_Name;
END
