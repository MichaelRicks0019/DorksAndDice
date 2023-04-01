using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories
{
    public class AddressRepository<Address> : IAddressRepository<Address> where Address : Logic.Models.CustomerData.Address
    {
        private readonly ISqlDataAccess _db;

        public AddressRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task Delete(int id)
        {
            return _db.SaveData("dbo.Address_Delete", new { Id = id });
        }

        public Task<List<Address>> GetAll()
        {
            return _db.LoadData<Address, dynamic>("dbo.Address_GetAll", new { });
        }

        public Task<List<Address>> GetByAddress1(string address)
        {
            return _db.LoadData<Address, string>("dbo.Address_GetByAddress1", address);
        }

        public Task<List<Address>> GetByAddress2(string address)
        {
            return _db.LoadData<Address, string>("dbo.Address_GetByAddress2", address);
        }

        public Task<List<Address>> GetByApartmentNumeber(int addressId)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetByApartmentNumber", addressId);
        }

        public Task<List<Address>> GetByCityId(int cityid)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetByCityId", cityid);
        }

        public Task<List<Address>> GetById(int id)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetById", id);
            
        }

        public Task<List<Address>> GetByPostalCode(string postalCode)
        {
            return _db.LoadData<Address, string>("dbo.Address_GetByPostalCode", postalCode);
            
        }

        public DateTime GetLastUpdate(int addressId)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetById", addressId).Result.First().Last_Update;
        }

        public Task Insert(Address entity)
        {
            return _db.SaveData("dbo.Address_Insert @Address1, @Address2, @City_Id, @Apartment_Number, @Postal_Code, @Last_Update", new { Address1 = entity.Address1, Address2 = entity.Address2, entity.City_Id, entity.Apartment_Number, entity.Postal_Code, entity.Last_Update });
        }

        public Task Update(Address entity)
        {
            return _db.SaveData("dbo.Address_Insert @Address_Id, @Address1, @Address2, @City_Id, @Apartment_Number, @Postal_Code, @Last_Update", entity);
        }
    }
}
