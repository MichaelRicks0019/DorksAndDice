CREATE PROCEDURE [dbo].[Type_Update]
	@Type_Id int,
	@Dice_Type nvarchar(75)
AS
BEGIN
	UPDATE [dbo].[Type]
	SET Dice_Type = @Dice_Type
	WHERE Type_Id = @Type_Id;
END
