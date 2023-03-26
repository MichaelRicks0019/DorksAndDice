CREATE PROCEDURE [dbo].[Product_Insert]
	@Product_Id int,
	@Product_Name nvarchar(MAX),
	@Product_Quantity int,
	@Product_Price decimal (18,0),
	@Product_Type nvarchar(50)
AS
BEGIN
	INSERT INTO [dbo].[Product] (Product_Id, Product_Name, Product_Quantity, Product_Price, Product_Type)
	VALUES (@Product_Id,
	@Product_Name,
	@Product_Quantity,
	@Product_Price,
	@Product_Type);
END
