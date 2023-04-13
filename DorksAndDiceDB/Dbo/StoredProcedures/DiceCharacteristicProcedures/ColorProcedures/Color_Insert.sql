CREATE PROCEDURE [dbo].[Color_Insert]
	@Dice_Color nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Color] (Dice_Color)
	VALUES (@Dice_Color);
END
