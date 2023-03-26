CREATE PROCEDURE [dbo].[Product_Update]
	@Product_Id int,
	@Product_Name nvarchar(MAX),
	@Product_Quantity int,
	@Product_Price decimal (18,0),
	@Product_Type nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[Product]
	SET Product_Name = @Product_Name,
	Product_Quantity = @Product_Quantity,
	Product_Price = @Product_Price,
	Product_Type = @Product_Type
	WHERE Product_Id = @Product_Id;
END
