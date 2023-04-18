CREATE PROCEDURE [dbo].[Dice_Update]
	@Dice_Id int,
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
	UPDATE [dbo].[Dice]
	SET Dice_Name = @Dice_Name,
	Dice_Quantity = @Dice_Quantity,
	Dice_Price = @Dice_Price,
	Edge = @Edge,
	Color = @Color,
	Material = @Material,
	Style = @Style,
	Type = @Type,
	Size = @Size
	WHERE Dice_Id = @Dice_Id;
END
