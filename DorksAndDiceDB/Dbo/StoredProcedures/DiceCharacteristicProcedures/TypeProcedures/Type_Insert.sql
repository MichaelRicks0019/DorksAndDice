CREATE PROCEDURE [dbo].[Type_Insert]
	@Dice_Type nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Type] (Dice_Type)
	VALUES (@Dice_Type);
END
