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
        List<Product> GetProductByName (string name);
        List<Product> GetProductByQuantity (int quantity);
        List<Product> GetProductByPrice (decimal price);
        List<Product> GetProductByType(string type);

    }
}
