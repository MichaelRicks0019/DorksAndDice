using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public class CountryRepository<Country> : ICountryRepository<Country> where Country : Logic.Models.CustomerData.Country
    {
        private readonly ISqlDataAccess _db;

        public CountryRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task Delete(int id)
        {
            return _db.SaveData("Country_Delete @Country_Id", id);
        }

        public Task<List<Country>> GetAll()
        {
            return _db.LoadData<Country, dynamic>("Country_GetAll", new { });
        }

        public Task<List<Country>> GetById(int id)
        {
            return _db.LoadData<Country, int>("Country_GetById @Country_Id", id);
        }

        public Task<List<Country>> GetByName(string name)
        {
            return _db.LoadData<Country, string>("Country_GetByName @Country_Name", name);
        }

        public Task Insert(Country entity)
        {
            return _db.SaveData("Country_Insert @Country_Name, @Last_Update", new { entity.Country_Name, entity.Last_Update });
        }

        public DateTime LastUpdate(int countryId)
        {
            return _db.LoadData<DateTime, int>("Country_LastUpdate @Country_Id", countryId).Result.FirstOrDefault();
        }

        public Task Update(Country entity)
        {
            return _db.SaveData("Country_Insert @Country_Name, @Last_Update", entity);
        }
    }
}
