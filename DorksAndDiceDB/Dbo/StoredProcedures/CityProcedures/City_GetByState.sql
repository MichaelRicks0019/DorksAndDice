CREATE PROCEDURE [dbo].[City_GetByState]
	@State_Name nvarchar(50)
AS
BEGIN
	SELECT *
	FROM [dbo].[City]
	WHERE State_Name = @State_Name;
END