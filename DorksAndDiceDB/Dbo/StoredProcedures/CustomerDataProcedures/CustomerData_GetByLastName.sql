CREATE PROCEDURE [dbo].[CustomerData_GetByLastName]
	@Last_Name nvarchar(50)
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE Last_Name = @Last_Name;
END
