using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces;
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

        public int ActiveCount()
        {
            return _db.LoadData<int, dynamic>("CustomerData_ActiveCount", new { }).Result.FirstOrDefault();
        }

        public Task Delete(int id)
        {
            return _db.SaveData("CustomerData_Delete", id);
        }

        public Task<List<CustomerData>> GetAll()
        {
            return _db.LoadData<CustomerData, dynamic>("CustomerData_GetAll", new { });
        }

        public Task<List<CustomerData>> GetByAddressId(int addressId)
        {
            return _db.LoadData<CustomerData, int>("CustomerData_GetByAddressId", addressId);
        }

        public Task<List<CustomerData>> GetByEmail(string email)
        {
            return _db.LoadData<CustomerData, string>("CustomerData_GetByEmail", email);

        }

        public Task<List<CustomerData>> GetByFirstName(string name)
        {
            return _db.LoadData<CustomerData, string>("CustomerData_GetByFirstName", name);

        }

        public Task<List<CustomerData>> GetByFullName(string fullName)
        {
            return _db.LoadData<CustomerData, string>("CustomerData_GetByFullName", fullName);

        }

        public Task<List<CustomerData>> GetById(int id)
        {
            return _db.LoadData<CustomerData, int>("CustomerData_GetById", id);

        }

        public Task<List<CustomerData>> GetByLastName(string lastName)
        {
            return _db.LoadData<CustomerData, string>("CustomerData_GetByLastName", lastName);

        }

        public Task<List<CustomerData>> GetByMiddleName(string name)
        {
            return _db.LoadData<CustomerData, string>("CustomerData_GetByMiddleName", name);

        }

        public Task<List<CustomerData>> GetByPhoneNumber(string phoneNumber)
        {
            return _db.LoadData<CustomerData, string>("CustomerData_GetByPhoneNumber", phoneNumber);

        }

        public DateTime GetCreateDate(int customerId)
        {
            return _db.LoadData<DateTime, int>("CustomerData_GetByAddressId", customerId).Result.FirstOrDefault();

        }

        public Task Insert(CustomerData entity)
        {
            return _db.SaveData("CustomerData_Insert @First_Name, @Middle_Name, @Last_Name, @Email, @Phone_Number, @Address_Id, @Status_Active, @Create_Date, @Last_Logged_On",
                new
                {
                    entity.Middle_Name,
                    entity.Last_Name,
                    entity.Email,
                    entity.Phone_Number,
                    entity.Address_Id,
                    entity.Status_Active,
                    entity.Create_Date,
                    entity.Last_Logged_On
                });
        }

        public DateTime LastLoggedOn(int customerId)
        {
            return _db.LoadData<DateTime, int>("CustomerData_LastLoggedOn", customerId).Result.FirstOrDefault();
        }

        public Task Update(CustomerData entity)
        {
            return _db.SaveData("CustomerData_Insert", entity);

        }
    }
}
