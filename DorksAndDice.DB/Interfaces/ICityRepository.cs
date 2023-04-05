namespace DorksAndDice.DB.DataRepositories
{
    public interface ICityRepository<City> where City : Logic.Models.CustomerData.City
    {
        Task Delete(int id);
        Task<List<City>> GetAll();
        Task<City?> GetById(int id);
        Task<List<City>> GetByName(string name);
        Task<List<City>> GetByState(int state);
        int GetCountryId(int cityId);
        Task Insert(City entity);
        DateTime LastUpdate(int cityId);
        Task Update(City entity);
    }
}