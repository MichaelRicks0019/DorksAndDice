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
    public class AddressRepository : IAddressRepository<Address>
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

        public Task<IEnumerable<Address>> GetAll()
        {
            return _db.LoadData<Address, dynamic>("dbo.Address_GetAll", new { });
        }

        public Task<IEnumerable<Address>> GetByAddress1(string address)
        {
            return _db.LoadData<Address, string>("dbo.Address_GetByAddress1", address);
        }

        public Task<IEnumerable<Address>> GetByAddress2(string address)
        {
            return _db.LoadData<Address, string>("dbo.Address_GetByAddress2", address);
        }

        public Task<IEnumerable<Address>> GetByApartmentNumeber(int addressId)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetByApartmentNumber", addressId);
        }

        public Task<IEnumerable<Address>> GetByCityId(int cityid)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetByCityId", cityid);
        }

        public Task<IEnumerable<Address>> GetById(int id)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetById", id);
        }

        public Task<IEnumerable<Address>> GetByPostalCode(string postalCode)
        {
            return _db.LoadData<Address, string>("dbo.Address_GetByPostalCode", postalCode);
        }

        public Task<DateTime> GetLastUpdate(int addressId)
        {
            return _db.LoadData<Address, int>("dbo.Address_GetLastUpdate", addressId).Result;
        }

        public int Insert(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Address entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
