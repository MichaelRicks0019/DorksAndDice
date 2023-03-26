CREATE PROCEDURE [dbo].[Dice_GetProductById]
	@Product_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Dice]
	WHERE Product_Id = @Product_Id;
END
