CREATE PROCEDURE [dbo].[Dice_GetByPrice]
	@Dice_Price decimal
AS
BEGIN
	SELECT *
	FROM [dbo].[Dice]
	WHERE Dice_Price = @Dice_Price;
END