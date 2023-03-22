CREATE PROCEDURE [dbo].[CustomerData_Insert]
	@Customer_Id int,
	@First_Name nvarchar(50),
	@Middle_Name nvarchar(50),
	@Last_Name nvarchar(50),
	@Email nvarchar(75),
	@Phone_Number nvarchar(15),
	@Address_Id int,
	@Status_Active bit,
	@Create_Date datetime,
	@Last_Logged_On datetime
AS
BEGIN
	UPDATE CustomerData
	SET First_Name = @First_Name, 
	Middle_Name = @Middle_Name, 
	Last_Name = @Last_Name, 
	Email = @Email, 
	Phone_Number = @Phone_Number,
	Address_Id = @Address_Id,
	Status_Active = @Status_Active,
	Create_Date = @Create_Date,
	Last_Logged_On = @Last_Logged_On;
END
