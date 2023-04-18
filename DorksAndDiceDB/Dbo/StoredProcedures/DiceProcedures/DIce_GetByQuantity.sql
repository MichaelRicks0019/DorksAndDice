CREATE PROCEDURE [dbo].[DIce_GetByQuantity]
	@Dice_Quantity int
AS
BEGIN
	SELECT *
	FROM [dbo].[Dice]
	WHERE Dice_Quantity = @Dice_Quantity;
END
