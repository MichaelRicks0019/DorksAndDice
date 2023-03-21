using DorksAndDice.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces
{
    public interface ICityRepository<City> : IGenericRepository<City>
    {
        //Regular Methods
        int GetCountryId(int cityId);
        List<City> GetByName (string name);
        List<City> GetByState (int state);
        DateTime LastUpdate(int cityId);

        //Async Methods
        Task<int> GetCitiesCountryIdAsync(int cityId);
        

    }
}
