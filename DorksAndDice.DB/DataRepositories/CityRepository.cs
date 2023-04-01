using DorksAndDice.DB.Interfaces;
using DorksAndDice.DB.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories
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

        public Task<List<City>> GetById(int id)
        {
            return _db.LoadData<City, int>("dbo.City_GetById @City_Id", id);
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
            return _db.LoadData<City, int>("dbo.City_GetCountryId @City_Id", cityId).Result.First().Country_Id;
        }

        public int Insert(City entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(City entity)
        {
            throw new NotImplementedException();
        }

        public DateTime LastUpdate(int cityId)
        {
            throw new NotImplementedException();
        }

        public int Update(City entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
