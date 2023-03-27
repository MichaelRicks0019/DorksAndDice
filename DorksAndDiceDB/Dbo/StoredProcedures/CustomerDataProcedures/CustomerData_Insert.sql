CREATE PROCEDURE [dbo].[CustomerData_Insert]
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
	INSERT INTO [dbo].[CustomerData] (First_Name, Middle_Name, Last_Name, Email, Phone_Number, Address_Id, Status_Active, Create_Date, Last_Logged_On)
	VALUES (@First_Name, 
	@Middle_Name, 
	@Last_Name, 
	@Email, 
	@Phone_Number,
	@Address_Id,
	@Status_Active,
	@Create_Date,
	@Last_Logged_On);
END