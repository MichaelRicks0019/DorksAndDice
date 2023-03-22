CREATE PROCEDURE [dbo].[CustomerData_GetByMiddleName]
	@Middle_Name nvarchar(50)
AS
BEGIN
	SELECT *
	FROM CustomerData
	WHERE Middle_Name = @Middle_Name;
END
