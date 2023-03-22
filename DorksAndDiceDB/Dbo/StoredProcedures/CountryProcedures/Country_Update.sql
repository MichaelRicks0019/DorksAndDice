CREATE PROCEDURE [dbo].[Country_Update]
	@Country_Id int,
	@Country_Name nvarchar(50),
	@Last_Update datetime
AS
BEGIN
	UPDATE [dbo].[Country]
	SET Country_Id = @Country_Id, 
	Country_Name = @Country_Name, 
	Last_Update = @Last_Update;
END
