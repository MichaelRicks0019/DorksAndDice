CREATE PROCEDURE [dbo].[Style_Insert]
	@Dice_Style nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Style] (Dice_Style)
	VALUES (@Dice_Style);
END
