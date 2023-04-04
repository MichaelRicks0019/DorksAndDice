using DorksAndDice.Logic.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Interfaces
{
    public interface IProductRepository<Product> : IGenericRepository<Product>
    {
        Task<List<Product>> GetByName (string name);
        Task<List<Product>> GetByQuantity (int quantity);
        Task<List<Product>> GetByPrice (decimal price);
        Task<List<Product>> GetByType(string type);
    }
}
