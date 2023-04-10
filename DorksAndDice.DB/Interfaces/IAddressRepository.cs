namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public interface IAddressRepository<Address> where Address : Logic.Models.CustomerData.Address
    {
        Task Delete(int id);
        Task<List<Address>> GetAll();
        Task<List<Address>> GetByAddress1(string address);
        Task<List<Address>> GetByAddress2(string address);
        Task<List<Address>> GetByApartmentNumeber(int addressId);
        Task<List<Address>> GetByCityId(int cityid);
        Task<Address?> GetById(int id);
        Task<List<Address>> GetByPostalCode(string postalCode);
        Task<DateTime> GetLastUpdate(int addressId);
        Task Insert(Address entity);
        Task Update(Address entity);
    }
}