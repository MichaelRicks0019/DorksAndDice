using DorksAndDice.DB.DataRepositories;
using DorksAndDice.DB.DataRepositories.CustomerDataRepositories;
using DorksAndDice.DB.DBAccess;
using DorksAndDice.Logic.Models.CustomerData;
using DorksAndDice.Logic.Models.Product;
using Microsoft.Extensions.Configuration;

ISqlDataAccess i = new SqlDataAccess("Server=localhost\\SQLEXPRESS01;Database=DorksAndDice;Trusted_Connection=True;");
City ogden = new City() { City_Id = 1, City_Name = "Ogden", Country_Id = 1, Last_Update = DateTime.UtcNow, State_Name = "Utah" };
ICityRepository<City> cityRepository = new CityRepository<City>(i);

cityRepository.Insert(ogden);

