using DorksAndDice.Logic.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Interfaces
{
    public interface IProductRepository<Order> : IGenericRepository<Product>
    {
        List<Product> GetByName (string name);
        List<Product> GetByQuantity (int quantity);
        List<Product> GetByPrice (decimal price);
        List<Product> GetByType(string type);
    }
}
