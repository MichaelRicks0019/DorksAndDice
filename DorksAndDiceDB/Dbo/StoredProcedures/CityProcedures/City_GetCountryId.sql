CREATE PROCEDURE [dbo].[City_GetCountryId]
	@CityId
AS
BEGIN

	SELECT CountryId
	FROM Country
	RIGHT JOIN CITY
	ON Country.Country_Id = City.Country_Id;
	
END
