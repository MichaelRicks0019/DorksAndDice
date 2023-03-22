CREATE PROCEDURE [dbo].[City_GetCountryId]
	@CityId int
AS
BEGIN
	SELECT CountryId
	FROM [dbo].[Country]
	RIGHT JOIN CITY
	ON Country.Country_Id = City.Country_Id;	
END
