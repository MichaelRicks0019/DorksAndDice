CREATE PROCEDURE [dbo].[Size_Insert]
	@Dice_Size nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Size] (Dice_Size)
	VALUES (@Dice_Size);
END
