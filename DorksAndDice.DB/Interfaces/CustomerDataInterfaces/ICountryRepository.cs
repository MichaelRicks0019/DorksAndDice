using DorksAndDice.Logic.Interfaces;

namespace DorksAndDice.DB.Interfaces.CustomerDataInterfaces
{
    public interface ICountryRepository<Country> : IGenericRepository<Country> where Country : Logic.Models.CustomerData.Country
    {
        Task<List<Country>> GetByName(string name);
        Task<DateTime> LastUpdate(int countryId);
    }
}