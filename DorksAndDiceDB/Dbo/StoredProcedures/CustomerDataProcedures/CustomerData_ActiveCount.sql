CREATE PROCEDURE [dbo].[CustomerData_ActiveCount]
AS
BEGIN
	SELECT Status_Active
	FROM CustomerData;
END