using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces
{
    public interface ICustomerRepository<CustomerData> : IGenericRepository<CustomerData>
    {
        //Regular Methods
        List<CustomerData>GetByFullName(string fullName);
        List<CustomerData> GetByFirstName(string name);
        List<CustomerData>GetByMiddleName(string name);
        List<CustomerData> GetByLastName(string lastName);
        List<CustomerData> GetByPhoneNumber(string phoneNumber);
        List<CustomerData> GetByEmail(string email);
        List<CustomerData> GetByAddressId(int addressId);
        int ActiveCount();
        DateTime GetCreateDate(int customerId);
        DateTime LastLoggedOn(int customerId);
        
        //Async Methods
        Task<DateTime> GetCreateDateAsync(int customerId);
        Task<DateTime> LastLoggedOnAsync(int customerId);
    }
}
