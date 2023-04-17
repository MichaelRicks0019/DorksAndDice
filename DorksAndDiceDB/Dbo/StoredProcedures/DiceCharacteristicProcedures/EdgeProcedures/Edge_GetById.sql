CREATE PROCEDURE [dbo].[Edge_GetById]
	@Edge_Id int
AS
BEGIN
	SELECT *
	FROM [dbo].[Edge]
	WHERE Edge_Id = @Edge_Id;
END