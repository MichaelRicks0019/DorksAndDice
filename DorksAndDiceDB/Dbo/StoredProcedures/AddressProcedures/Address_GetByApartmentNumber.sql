CREATE PROCEDURE [dbo].[Address_GetByApartmentNumber]
	@Apartment_Number int
AS
BEGIN
	SELECT *
	FROM [dbo].[Address] 
	WHERE Apartment_Number = @Apartment_Number;
END
