CREATE PROCEDURE [dbo].[Material_GetByMaterial]
	@Dice_Material nvarchar(75)
AS
BEGIN
	SELECT *
	FROM [dbo].[Material]
	WHERE Dice_Material = @Dice_Material;
END
