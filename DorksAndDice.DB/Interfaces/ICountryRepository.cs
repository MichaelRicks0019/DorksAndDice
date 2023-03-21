using DorksAndDice.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces
{
    public interface ICountryRepository<Country> : IGenericRepository<Country>
    {
        List<Country> GetByName (string name);
        DateTime LastUpdate(int countryId);
    }
}
