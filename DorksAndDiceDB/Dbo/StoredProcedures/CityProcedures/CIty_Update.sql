CREATE PROCEDURE [dbo].[CIty_Update]
	@City_Id int,
	@Country_Id int,
	@City_Name varchar(50),
	@State_Name varchar(50),
	@Last_Update datetime
AS
BEGIN
	UPDATE [dbo].[City]
	SET Country_Id = @Country_Id,
	City_Name = @City_Name,
	State_Name = @State_Name,
	Last_Update = @Last_Update
	WHERE City_Id = @City_Id;
END
