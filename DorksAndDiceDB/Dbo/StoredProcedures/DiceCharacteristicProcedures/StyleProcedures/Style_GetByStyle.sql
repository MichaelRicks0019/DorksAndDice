CREATE PROCEDURE [dbo].[Style_GetByStyle]
	@Dice_Style nvarchar(75)
AS
BEGIN
	SELECT * 
	FROM [dbo].[Style]
	WHERE Dice_Style = @Dice_Style;
END