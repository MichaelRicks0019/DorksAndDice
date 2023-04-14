CREATE PROCEDURE [dbo].[Type_GetByType]
	@Dice_Type nvarchar(75)
AS
BEGIN
	SELECT * 
	FROM [dbo].[Type]
	WHERE Dice_Type = @Dice_Type;
END
