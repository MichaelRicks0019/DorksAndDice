using DorksAndDice.Logic.Models.CustomerData;

namespace DorksAndDice.DB.DBAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters);
        Task SaveData<T>(string storedProcedure, T parameters);
    }
}