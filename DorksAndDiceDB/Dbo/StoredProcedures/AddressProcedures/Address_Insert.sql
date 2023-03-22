CREATE PROCEDURE [dbo].[Address_Insert]
	@Address_Id int,
	@Address1 nvarchar(75),
	@Address2 nvarchar(75),
	@City_Id int,
	@Apartment_Number int,
	@Postal_Code nvarchar(25),
	@Last_Update datetime
AS
BEGIN
	UPDATE [dbo].[Address]
	VALUES (@Address1, 
	@Address2, 
	@City_Id, 
	@Apartment_Number, 
	@Postal_Code, 
	@Last_Update);
END
