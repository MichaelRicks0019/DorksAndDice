CREATE PROCEDURE [dbo].[Material_Insert]
	@Dice_Material nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Material] (Dice_Material)
	VALUES (@Dice_Material);
END
