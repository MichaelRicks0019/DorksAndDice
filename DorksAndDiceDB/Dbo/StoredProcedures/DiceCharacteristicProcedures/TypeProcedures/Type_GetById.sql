CREATE PROCEDURE [dbo].[Type_GetById]
	@Type_Id nvarchar(75)
AS
BEGIN
	SELECT * 
	FROM [dbo].[Type]
	WHERE Type_Id = @Type_Id; 
END
