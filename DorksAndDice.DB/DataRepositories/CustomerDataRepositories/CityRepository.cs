using DorksAndDice.DB.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorksAndDice.Logic.Models.CustomerData;

namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public class CityRepository<City> : ICityRepository<City> where City : Logic.Models.CustomerData.City
    {
        private readonly ISqlDataAccess _db;

        public CityRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task Delete(int id)
        {
            return _db.SaveData("dbo.City_Delete @City_Id", new { City_Id = id });
        }

        public Task<List<City>> GetAll()
        {
            return _db.LoadData<City, dynamic>("dbo.City_GetAll", new { });
        }

        public async Task<City?> GetById(int id)
        {
            var results = await _db.LoadData<City, dynamic>("dbo.City_GetById", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task<List<City>> GetByName(string name)
        {
            return _db.LoadData<City, string>("dbo.City_GetByName @City_Name", name);
        }

        public Task<List<City>> GetByState(int state)
        {
            return _db.LoadData<City, int>("dbo.City_GetByState @State_Name", state);
        }

        public int GetCountryId(int cityId)
        {
            return _db.LoadData<int, int>("dbo.City_GetCountryId @City_Id", cityId).Result.FirstOrDefault();
        }

        public Task Insert(City entity)
        {
            return _db.SaveData("dbo.City_Insert @Country_Id, @City_Name, @State_Name, @Last_Update", new { Country_Id = entity.Country_Id, City_Name = entity.City_Name, State_Name = entity.State_Name, Last_Update = entity.Last_Update });
        }

        public DateTime LastUpdate(int cityId)
        {
            return _db.LoadData<DateTime, int>("dbo.City_GetLastUpdate @City_Id", cityId).Result.FirstOrDefault();
        }

        public Task Update(City entity)
        {
            return _db.SaveData("dbo.City_Insert @Country_Id, @City_Name, @State_Name, @Last_Update", entity);
        }
    }
}
