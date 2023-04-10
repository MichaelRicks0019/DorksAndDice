using DorksAndDice.DB.DBAccess;
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

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Country_Delete @Country_Id", id);
        }

        public async Task<List<Country>> GetAll()
        {
            var results = await _db.LoadData<Country, dynamic>("dbo.Country_GetAll", new { });
            return results.ToList();
        }

        public async Task<Country?> GetById(int id)
        {
            var results = await _db.LoadData<Country, int>("dbo.Country_GetById @Country_Id", id);
            return results.FirstOrDefault();
        }

        public async Task<List<Country>> GetByName(string name)
        {
            var results = await _db.LoadData<Country, string>("dbo.Country_GetByName @Country_Name", name);
            return results.ToList();
        }

        public async Task Insert(Country entity)
        {
            await _db.SaveData("dbo.Country_Insert @Country_Name, @Last_Update", new { Country_Name = entity.Country_Name, Last_Update = entity.Last_Update });
        }

        public async Task<DateTime> LastUpdate(int countryId)
        {
            var results = await _db.LoadData<DateTime, int>("dbo.Country_LastUpdate @Country_Id", countryId);
            return results.FirstOrDefault();
        }

        public async Task Update(Country entity)
        {
            await _db.SaveData("dbo.Country_Insert @Country_Name, @Last_Update", entity);
        }
    }
}
