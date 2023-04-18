CREATE PROCEDURE [dbo].[Dice_GetByName]
	@Dice_Name nvarchar(75)
AS
BEGIN
	SELECT *
	FROM [dbo].[Dice]
	WHERE Dice_Name = @Dice_Name;
END
