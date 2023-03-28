CREATE PROCEDURE [dbo].[Dice_Insert]
	@Product_Id int,
	@Edge nvarchar(75),
	@Color nvarchar(75),
	@Material nvarchar(75),
	@Style nvarchar(75),
	@Type nvarchar(75),
	@Size nvarchar(75)
AS
BEGIN
	INSERT INTO [dbo].[Dice] (Product_Id, Edge, Color, Material, Style, Type, Size)
	VALUES (@Product_Id,
	@Edge,
	@Color,
	@Material,
	@Style,
	@Type,
	@Size);
END