CREATE PROCEDURE [dbo].[City_Insert]
	@City_Id int,
	@Country_Id int,
	@City_Name varchar(50),
	@State_Name varchar(50),
	@Last_Update datetime
AS
BEGIN
	INSERT INTO [dbo].[City]
	VALUES (@City_Id,
	@Country_Id,
	@City_Name,
	@State_Name,
	@Last_Update)
END
