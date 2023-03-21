CREATE TABLE [dbo].[CustomerData]
(
	[Customer_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [First_Name] NVARCHAR(50) NOT NULL, 
    [Middle_Name] NVARCHAR(50) NULL, 
    [Last_Name] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(75) NULL, 
    [Phone_Number] NVARCHAR(15) NULL, 
    [Address_Id] INT NULL, 
    [Status_Active] BIT NOT NULL, 
    [Create_Date] DATETIME NOT NULL, 
    [Last_Logged_On] DATETIME NULL
)
