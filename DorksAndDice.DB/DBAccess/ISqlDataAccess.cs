using DorksAndDice.Logic.Models.CustomerData;

namespace DorksAndDice.DB.DBAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters);
        Task SaveData<T>(string storedProcedure, T parameters);
        public void ChangeConnectionString(string connectionString);
    }
}