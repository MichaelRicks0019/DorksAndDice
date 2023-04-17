CREATE PROCEDURE [dbo].[Material_Update]
	@Material_Id int,
	@Dice_Material nvarchar(75)
AS
BEGIN
	UPDATE [dbo].[Material]
	SET Dice_Material = @Dice_Material
	WHERE Material_Id = @Material_Id;
END
