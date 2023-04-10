﻿using DorksAndDice.DB.DBAccess;
using DorksAndDice.Logic.Models.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public class AddressRepository<Address> : IAddressRepository<Address> where Address : Logic.Models.CustomerData.Address
    {
        private readonly ISqlDataAccess _db;

        public AddressRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Address_Delete", new { Id = id });
        }

        public async Task<List<Address>> GetAll()
        {
            var results = await _db.LoadData<Address, dynamic>("dbo.Address_GetAll", new { });
            return results.ToList();
        }

        public async Task<List<Address>> GetByAddress1(string address)
        {
            var results = await _db.LoadData<Address, string>("dbo.Address_GetByAddress1", address);
            return results.ToList();
        }

        public async Task<List<Address>> GetByAddress2(string address)
        {
            var results = await _db.LoadData<Address, string>("dbo.Address_GetByAddress2", address);
            return results.ToList();
        }

        public async Task<List<Address>> GetByApartmentNumeber(int addressId)
        {
            var results = await _db.LoadData<Address, int>("dbo.Address_GetByApartmentNumber", addressId);
            return results.ToList();
        }

        public async Task<List<Address>> GetByCityId(int cityid)
        {
            var results = await _db.LoadData<Address, int>("dbo.Address_GetByCityId", cityid);
            return results.ToList();
        }

        public async Task<Address?> GetById(int id)
        {
            var results = await _db.LoadData<Address, int>("dbo.Address_GetById", id);
            return results.FirstOrDefault();

        }

        public async Task<List<Address>> GetByPostalCode(string postalCode)
        {
            var results = await _db.LoadData<Address, string>("dbo.Address_GetByPostalCode", postalCode);
            return results.ToList();

        }

        public async Task<DateTime> GetLastUpdate(int addressId)
        {
            var results = await _db.LoadData<DateTime, int>("dbo.Address_GetById", addressId);
            return results.FirstOrDefault();
        }

        public async Task Insert(Address entity)
        {
            await _db.SaveData("dbo.Address_Insert @Address1, @Address2, @City_Id, @Apartment_Number, @Postal_Code, @Last_Update", new { Address1 = entity.Address1, Address2 = entity.Address2, City_Id = entity.City_Id, Apartment_Number = entity.Apartment_Number, Postal_Code = entity.Postal_Code, Last_Update = entity.Last_Update });
        }

        public async Task Update(Address entity)
        {
            await _db.SaveData("dbo.Address_Insert @Address_Id, @Address1, @Address2, @City_Id, @Apartment_Number, @Postal_Code, @Last_Update", entity);
        }
    }
}
