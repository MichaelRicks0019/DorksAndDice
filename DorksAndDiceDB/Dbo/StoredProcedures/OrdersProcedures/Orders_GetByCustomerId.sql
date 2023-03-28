CREATE PROCEDURE [dbo].[Orders_GetByCustomerId]
	@Customer_Id int
AS
BEGIN
	SELECT * 
	FROM [dbo].[Orders]
	WHERE Customer_Id = @Customer_Id;
END
