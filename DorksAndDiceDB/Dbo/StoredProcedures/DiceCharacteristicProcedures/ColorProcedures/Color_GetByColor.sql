CREATE PROCEDURE [dbo].[Color_GetByColor]
	@Dice_Color int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Color]
	WHERE Dice_Color = @Dice_Color;
END
