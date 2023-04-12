using DorksAndDice.Logic.Interfaces;

namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public interface ICustomerRepository<CustomerData> : IGenericRepository<CustomerData> where CustomerData : Logic.Models.CustomerData.CustomerData
    {
        Task<int> ActiveCount();
        Task<List<CustomerData>> GetByAddressId(int addressId);
        Task<List<CustomerData>> GetByEmail(string email);
        Task<List<CustomerData>> GetByFirstName(string name);
        Task<List<CustomerData>> GetByFullName(string fullName);
        Task<List<CustomerData>> GetByLastName(string lastName);
        Task<List<CustomerData>> GetByMiddleName(string name);
        Task<List<CustomerData>> GetByPhoneNumber(string phoneNumber);
        Task<DateTime> GetCreateDate(int customerId);
        Task<DateTime> LastLoggedOn(int customerId);
    }
}