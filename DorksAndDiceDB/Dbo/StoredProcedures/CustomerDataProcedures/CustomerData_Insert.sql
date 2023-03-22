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
	INSERT INTO CustomerData
	VALUES (@FIrst_Name, 
	@Middle_Name, 
	@Last_Name, 
	@Email, 
	@Phone_Number,
	@Address_Id,
	@Status_Active,
	@Create_Date,
	@Last_Logged_On);
END