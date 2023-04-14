CREATE PROCEDURE [dbo].[Type_Delete]
	@Type_Id int
AS
BEGIN
	DELETE [dbo].[Type]
	WHERE Type_Id = @Type_Id;
END
