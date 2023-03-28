CREATE PROCEDURE [dbo].[Dice_Delete]
	@Dice_Id int
AS
BEGIN
	DELETE [dbo].[Dice]
	WHERE Dice_Id = @Dice_Id;
END
