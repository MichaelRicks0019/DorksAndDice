CREATE PROCEDURE [dbo].[CustomerData_GetByFullName]
	@First_Name nvarchar(50),
	@Middle_Name nvarchar(50),
	@Last_Name nvarchar(50)
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE First_Name = @First_Name
	AND Middle_Name = @Middle_Name
	AND Last_Name = @Last_Name;
END
