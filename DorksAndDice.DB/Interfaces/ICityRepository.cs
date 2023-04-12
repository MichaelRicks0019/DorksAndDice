using DorksAndDice.Logic.Interfaces;

namespace DorksAndDice.DB.Interfaces
{
    public interface ICityRepository<City> : IGenericRepository<City> where City : Logic.Models.CustomerData.City
    {
        Task<List<City>> GetByName(string name);
        Task<List<City>> GetByState(int state);
        Task<int> GetCountryId(int cityId);
        Task<DateTime> LastUpdate(int cityId);
    }
}