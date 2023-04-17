CREATE PROCEDURE [dbo].[Size_Update]
	@Size_Id int,
	@Dice_Size nvarchar(75)
AS
BEGIN
	UPDATE [dbo].[Size]
	SET Dice_Size = @Dice_Size
	WHERE Size_Id = @Size_Id;
END
