using DorksAndDice.DB.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorksAndDice.Logic.Models.CustomerData;
using DorksAndDice.DB.Interfaces;

namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public class CityRepository<City> : ICityRepository<City> where City : Logic.Models.CustomerData.City
    {
        private readonly ISqlDataAccess _db;
        private City insert;

        public CityRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.City_Delete @City_Id", new { City_Id = id });
        }

        public async Task<List<City>> GetAll()
        {
            var results = await _db.LoadData<City, dynamic>("dbo.City_GetAll", new { });
            return results.ToList();
        }

        public async Task<City?> GetById(int id)
        {
            var results = await _db.LoadData<City, dynamic>("dbo.City_GetById @City_Id", new { City_Id = id });
            return results.FirstOrDefault();
        }

        public async Task<List<City>> GetByName(string name)
        {
            var results = await _db.LoadData<City, string>("dbo.City_GetByName @City_Name", name);
            return results.ToList();
        }

        public async Task<List<City>> GetByState(int state)
        {
            var results = await _db.LoadData<City, int>("dbo.City_GetByState @State_Name", state);
            return results.ToList();
        }

        public async Task<int> GetCountryId(int cityId)
        {
            var results = await _db.LoadData<int, int>("dbo.City_GetCountryId @City_Id", cityId);
            return results.FirstOrDefault();
        }

        public async Task Insert(City entity)
        {
            await _db.SaveData("dbo.City_Insert @Country_Id, @City_Name, @State_Name, @Last_Update", new { Country_Id = entity.Country_Id, City_Name = entity.City_Name, State_Name = entity.State_Name, Last_Update = entity.Last_Update });
        }

        public async Task<DateTime> LastUpdate(int cityId)
        {
            var results = await _db.LoadData<DateTime, int>("dbo.City_GetLastUpdate @City_Id", cityId);
            return results.FirstOrDefault();
        }

        public async Task Update(City entity)
        {
            await _db.SaveData("dbo.City_Insert @Country_Id, @City_Name, @State_Name, @Last_Update", entity);
        }
    }
}
