CREATE PROCEDURE [dbo].[Dice_Update]
	@Product_Id int,
	@Edge nvarchar(75),
	@Color nvarchar(75),
	@Material nvarchar(75),
	@Style nvarchar(75),
	@Type nvarchar(75),
	@Size nvarchar(75)
AS
BEGIN
	UPDATE [dbo].[Dice]
	SET Edge = @Edge,
	Color = @Color,
	Material = @Material,
	Style = @Style,
	Type = @Type,
	Size = @Size
	WHERE Product_Id = Product_Id;
END
