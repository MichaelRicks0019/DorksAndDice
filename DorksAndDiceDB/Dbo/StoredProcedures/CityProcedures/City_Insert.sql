CREATE PROCEDURE [dbo].[City_Insert]
	@Country_Id int,
	@City_Name nvarchar(50),
	@State_Name nvarchar(50),
	@Last_Update datetime
AS
BEGIN
	INSERT INTO [dbo].[City] (Country_Id, City_Name, State_Name, Last_Update)
	VALUES (@Country_Id,
	@City_Name,
	@State_Name,
	@Last_Update)
END
