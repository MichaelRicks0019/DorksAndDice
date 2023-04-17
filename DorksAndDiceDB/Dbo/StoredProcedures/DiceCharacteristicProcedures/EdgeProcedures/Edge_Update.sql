CREATE PROCEDURE [dbo].[Edge_Update]
	@Edge_Id int,
	@Dice_Edge nvarchar(75)
AS
BEGIN
	UPDATE [dbo].[Edge]
	SET Dice_Edge = @Dice_Edge
	WHERE Edge_Id = @Edge_Id;
END