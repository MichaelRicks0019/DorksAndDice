CREATE PROCEDURE [dbo].[Size_GetBySize]
	@Dice_Size nvarchar(75)
AS
BEGIN
	SELECT *
	FROM [dbo].[Size]
	WHERE Dice_Size = @Dice_Size;
END
