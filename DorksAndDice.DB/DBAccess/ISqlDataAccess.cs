using DorksAndDice.Logic.Models.CustomerData;

namespace DorksAndDice.DB.DBAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Server=localhost\\SQLEXPRESS01;Database=DorksAndDice;Trusted_Connection=True;");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Server=localhost\\SQLEXPRESS01;Database=DorksAndDice;Trusted_Connection=True;");
    }
}