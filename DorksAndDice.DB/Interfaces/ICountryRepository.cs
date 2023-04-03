using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;

namespace DorksAndDice.DB.DataRepositories
{
    public interface ICountryRepository<Country> : IGenericRepository<Country>
    {
        Task<List<Country>> GetByName(string name);
        DateTime LastUpdate(int countryId);
    }
}