CREATE PROCEDURE [dbo].[City_Insert]
	@City_Id int,
	@Country_Id int,
	@City_Name nvarchar(50),
	@State_Name nvarchar(50),
	@Last_Update datetime
AS
BEGIN
	INSERT INTO [dbo].[City] (City_Id, Country_Id, City_Name, State_Name, Last_Update)
	VALUES (@City_Id,
	@Country_Id,
	@City_Name,
	@State_Name,
	@Last_Update)
END
