CREATE PROCEDURE [dbo].[City_GetCountryId]
	@CityId int
AS
BEGIN
	SELECT ci.Country_Id
	FROM Country c
	RIGHT JOIN City ci
	ON c.Country_Id = ci.Country_Id;	
END
