CREATE PROCEDURE [dbo].[Address_Update]
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
	SET Address1 = @Address1, Address2 = @Address2, City_Id = @City_Id, Apartment_Number = @Apartment_Number, Postal_Code = @Postal_Code, Last_Update = @Last_Update
	WHERE Address_Id = @Address_Id;
END
