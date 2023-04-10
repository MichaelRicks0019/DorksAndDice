namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public interface ICountryRepository<Country> where Country : Logic.Models.CustomerData.Country
    {
        Task Delete(int id);
        Task<List<Country>> GetAll();
        Task<Country?> GetById(int id);
        Task<List<Country>> GetByName(string name);
        Task Insert(Country entity);
        Task<DateTime> LastUpdate(int countryId);
        Task Update(Country entity);
    }
}