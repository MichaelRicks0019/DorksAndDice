using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Interfaces
{
    public interface IGenericRepository<T>
    {
        //Gets entity by Id. Main Id, not Foriegn Key
        Task<T?> GetById(int id);
        //Gets all entities an returns list
        Task<List<T>> GetAll();
        //Adds entity to database
        Task Insert(T entity);
        //Finds entity in database based on Id and replaces it if different
        Task Update(T entity);
        //Removes entity from database
        Task Delete(int id);
    }
}
