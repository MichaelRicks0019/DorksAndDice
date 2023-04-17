CREATE PROCEDURE [dbo].[Edge_GetByEdge]
	@Dice_Edge nvarchar(75)
AS
BEGIN
	SELECT *
	FROM [dbo].[Edge]
	WHERE Dice_Edge = @Dice_Edge;
END
