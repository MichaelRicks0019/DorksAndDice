using DorksAndDice.DB.DBAccess;
using DorksAndDice.Logic.Models.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.CustomerDataRepositories
{
    public class CustomerRepository<CustomerData> : ICustomerRepository<CustomerData> where CustomerData : Logic.Models.CustomerData.CustomerData
    {
        private readonly ISqlDataAccess _db;

        public CustomerRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<int> ActiveCount()
        {
            var results = await _db.LoadData<int, dynamic>("dbo.CustomerData_ActiveCount", new { });
            return results.FirstOrDefault();
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.CustomerData_Delete", id);

        }

        public async Task<List<CustomerData>> GetAll()
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetAll", new { });
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByAddressId(int addressId)
        {
            var results = await _db.LoadData<CustomerData, int>("dbo.CustomerData_GetByAddressId", addressId);
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByEmail(string email)
        {
            var results = await _db.LoadData<CustomerData, string>("dbo.CustomerData_GetByEmail", email);
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByFirstName(string name)
        {
            var results = await _db.LoadData<CustomerData, string>("dbo.CustomerData_GetByFirstName", name);
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByFullName(string fullName)
        {
            var results = await _db.LoadData<CustomerData, string>("dbo.CustomerData_GetByFullName", fullName);
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetById(int id)
        {
            var results = await _db.LoadData<CustomerData, int>("dbo.CustomerData_GetById", id);
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByLastName(string lastName)
        {
            var results = await _db.LoadData<CustomerData, string>("dbo.CustomerData_GetByLastName", lastName);
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByMiddleName(string name)
        {
            var results = await _db.LoadData<CustomerData, string>("dbo.CustomerData_GetByMiddleName", name);
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByPhoneNumber(string phoneNumber)
        {
            var results = await _db.LoadData<CustomerData, string>("dbo.CustomerData_GetByPhoneNumber", phoneNumber);
            return results.ToList();
        }

        public async Task<DateTime> GetCreateDate(int customerId)
        {
            var results = await _db.LoadData<DateTime, int>("dbo.CustomerData_GetByAddressId", customerId);
            return results.FirstOrDefault();
        }

        public async Task Insert(CustomerData entity)
        {
            await _db.SaveData("CustomerData_Insert @First_Name, @Middle_Name, @Last_Name, @Email, @Phone_Number, @Address_Id, @Status_Active, @Create_Date, @Last_Logged_On",
                new
                {
                    Middle_Name = entity.Middle_Name,
                    Last_Name = entity.Last_Name,
                    Email = entity.Email,
                    Phone_Number = entity.Phone_Number,
                    Address_Id = entity.Address_Id,
                    Status_Active = entity.Status_Active,
                    Create_Date = entity.Create_Date,
                    Last_Logged_On = entity.Last_Logged_On
                });
        }

        public async Task<DateTime> LastLoggedOn(int customerId)
        {
            var results = await _db.LoadData<DateTime, int>("CustomerData_LastLoggedOn", customerId);
            return results.FirstOrDefault();
        }

        public async Task Update(CustomerData entity)
        {
            await _db.SaveData("CustomerData_Insert", entity);

        }
    }
}
