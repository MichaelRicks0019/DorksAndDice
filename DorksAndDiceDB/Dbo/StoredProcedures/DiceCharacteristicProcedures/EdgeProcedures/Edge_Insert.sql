CREATE PROCEDURE [dbo].[Edge_Insert]
	@Dice_Edge nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Edge] (Dice_Edge)
	VALUES (@Dice_Edge);
END
