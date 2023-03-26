CREATE PROCEDURE [dbo].[Dice_GetDiceById]
	@Dice_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Dice]
	WHERE Dice_Id = @Dice_Id;
END
