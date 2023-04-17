CREATE PROCEDURE [dbo].[Style_Update]
	@Style_Id int,
	@Dice_Style nvarchar(75)
AS
BEGIN
	UPDATE [dbo].[Style]
	SET Dice_Style = @Dice_Style
	WHERE Style_Id = @Style_Id;
END
