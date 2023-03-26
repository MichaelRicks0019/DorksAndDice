CREATE PROCEDURE [dbo].[Country_Insert]
	@Country_Id int,
	@Country_Name nvarchar(50),
	@Last_Update datetime
AS
BEGIN
	INSERT INTO [dbo].[Country] (Country_Id, Country_Name, Last_Update)
	VALUES (@Country_Id, 
	@Country_Name, 
	@Last_Update);
END
