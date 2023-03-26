CREATE PROCEDURE [dbo].[Dice_GetDiceCharacteristicBy]
	@Edge nvarchar(75),
	@Color nvarchar(75),
	@Material nvarchar(75),
	@Style nvarchar(75), 
	@Type nvarchar(75),
	@Size nvarchar(75)
AS
BEGIN
	SELECT *
	FROM [dbo].[Dice]
	WHERE Edge LIKE '%' + ISNULL(@Edge, Edge) + '%' 
	AND Color LIKE '%' + ISNULL(@Color, Color) + '%'
	AND Material LIKE '%' + ISNULL(@Material, Material) + '%'
	AND Style LIKE '%' + ISNULL(@Style, Style) + '%'
	AND Type LIKE '%' + ISNULL(@Type, Type) + '%'
	AND Size LIKE '%' + ISNULL(@Size, Size) + '%'
END
