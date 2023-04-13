using DorksAndDice.Logic.Interfaces;

namespace DorksAndDice.DB.Interfaces.CustomerDataInterfaces
{
    public interface IAddressRepository<Address> : IGenericRepository<Address> where Address : Logic.Models.CustomerData.Address
    {
        Task<List<Address>> GetByAddress1(string address);
        Task<List<Address>> GetByAddress2(string address);
        Task<List<Address>> GetByApartmentNumeber(int addressId);
        Task<List<Address>> GetByCityId(int cityid);
        Task<List<Address>> GetByPostalCode(string postalCode);
        Task<DateTime> GetLastUpdate(int addressId);
    }
}