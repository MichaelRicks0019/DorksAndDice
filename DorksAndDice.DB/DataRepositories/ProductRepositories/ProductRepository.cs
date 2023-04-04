using DorksAndDice.DB.DBAccess;
using DorksAndDice.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories
{
    public class ProductRepository<Product> : IProductRepository<Product> where Product : Logic.Models.Product.Product
    {
        private readonly ISqlDataAccess _db;

        public ProductRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task Delete(int id)
        {
            return _db.SaveData("Product_Delete", id);
        }

        public Task<List<Product>> GetAll()
        {
            return _db.LoadData<Product, dynamic>("Product_GetAll", new { });
        }

        public Task<List<Product>> GetById(int id)
        {
            return _db.LoadData<Product, int>("Product_GetById", id);
        }

        public Task<List<Product>> GetByName(string name)
        {
            return _db.LoadData<Product, string>("Product_GetByName", name);
        }

        public Task<List<Product>> GetByPrice(decimal price)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetByQuantity(int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetByType(string type)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
