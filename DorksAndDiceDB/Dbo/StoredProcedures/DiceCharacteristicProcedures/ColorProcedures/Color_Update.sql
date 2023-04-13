CREATE PROCEDURE [dbo].[Color_Update]
	@Color_Id int,
	@Dice_Color nvarchar(75)
AS
BEGIN
	UPDATE [dbo].[Color]
	SET Dice_Color = @Dice_Color
	WHERE Color_Id = @Color_Id;
END
