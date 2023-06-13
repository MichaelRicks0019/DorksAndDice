using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.CustomerDataInterfaces;
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
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetByAddressId @Address_Id", new { Address_Id = addressId });
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByEmail(string email)
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetByEmail @Email", new { Email = email });
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByFirstName(string name)
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetByFirstName @First_Name", new { First_Name = name });
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByFullName(string firstName, string middleName, string lastName)
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetByFullName @First_Name, @Middle_Name, @Last_Name", new { First_Name = firstName, Middle_Name = middleName, Last_Name = lastName });
            return results.ToList();
        }

        public async Task<CustomerData?> GetById(int id)
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetById @Customer_Id", new { Customer_Id = id });
            return results.FirstOrDefault();
        }

        public async Task<List<CustomerData>> GetByLastName(string lastName)
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetByLastName @Last_Name", new { Last_Name = lastName });
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByMiddleName(string name)
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetByMiddleName @Middle_Name", new { Middle_Name = name });
            return results.ToList();
        }

        public async Task<List<CustomerData>> GetByPhoneNumber(string phoneNumber)
        {
            var results = await _db.LoadData<CustomerData, dynamic>("dbo.CustomerData_GetByPhoneNumber @Phone_Number", new { Phone_Number = phoneNumber });
            return results.ToList();
        }

        public async Task<DateTime> GetCreateDate(int customerId)
        {
            var results = await _db.LoadData<DateTime, dynamic>("dbo.CustomerData_GetCreateDate @Customer_Id", new { Customer_Id = customerId });
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
            var results = await _db.LoadData<DateTime, dynamic>("CustomerData_LastLoggedOn @Customer_Id", new { Customer_Id = customerId });
            return results.FirstOrDefault();
        }

        public async Task Update(CustomerData entity)
        {
            await _db.SaveData("CustomerData_Insert", entity);

        }
    }
}
