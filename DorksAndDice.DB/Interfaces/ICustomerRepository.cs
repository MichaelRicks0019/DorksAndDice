namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public interface ICustomerRepository<CustomerData> where CustomerData : Logic.Models.CustomerData.CustomerData
    {
        Task<int> ActiveCount();
        Task Delete(int id);
        Task<List<CustomerData>> GetAll();
        Task<List<CustomerData>> GetByAddressId(int addressId);
        Task<List<CustomerData>> GetByEmail(string email);
        Task<List<CustomerData>> GetByFirstName(string name);
        Task<List<CustomerData>> GetByFullName(string fullName);
        Task<List<CustomerData>> GetById(int id);
        Task<List<CustomerData>> GetByLastName(string lastName);
        Task<List<CustomerData>> GetByMiddleName(string name);
        Task<List<CustomerData>> GetByPhoneNumber(string phoneNumber);
        Task<DateTime> GetCreateDate(int customerId);
        Task Insert(CustomerData entity);
        Task<DateTime> LastLoggedOn(int customerId);
        Task Update(CustomerData entity);
    }
}