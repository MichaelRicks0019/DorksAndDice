using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces
{
    public interface IAddressRepository<Address> : IGenericRepository<Address>
    {
        List<Address> GetByAddress1(string address);
        List<Address> GetByAddress2(string address);
        List<Address> GetByCityId(int city_id);
        List<Address> GetByApartmentNumeber(int addressId);
        List<Address> GetByPostalCode (string postalCode);
        DateTime GetLastUpdate(int addressId);
    }
}
