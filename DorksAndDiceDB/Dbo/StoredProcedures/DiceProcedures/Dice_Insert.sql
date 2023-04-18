CREATE PROCEDURE [dbo].[Dice_Insert]
	@Dice_Name nvarchar(75),
	@Dice_Quantity int,
	@Dice_Price decimal,
	@Edge nvarchar(75),
	@Color nvarchar(75),
	@Material nvarchar(75),
	@Style nvarchar(75),
	@Type nvarchar(75),
	@Size nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Dice] (Dice_Name, Dice_Quantity, Dice_Price, Edge, Color, Material, Style, Type, Size)
	VALUES (@Dice_Name,
	@Dice_Quantity,
	@Dice_Price,
	@Edge,
	@Color,
	@Material,
	@Style,
	@Type,
	@Size);
END
