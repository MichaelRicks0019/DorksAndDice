using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.ProductInterfaces;
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

        public ProductRepository (ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Product_Delete @Product_Id", id);
        }

        public async Task<List<Product>> GetAll()
        {
            var results = await _db.LoadData<Product, dynamic>("dbo.Product_GetAll", new { });
            return results.ToList();
        }

        public async Task<Product?> GetById(int id)
        {
            var results = await _db.LoadData<Product, int>("dbo.Product_GetById @Product_Id", id);
            return results.FirstOrDefault();
        }

        public async Task<List<Product>> GetByName(string name)
        {
            var results = await _db.LoadData<Product, string>("dbo.Product_GetByName @Product_Name", name);
            return results.ToList();
        }

        public async Task<List<Product>> GetByPrice(decimal price)
        {
            var results = await _db.LoadData<Product, decimal>("dbo.Product_GetByPrice @Product_Price", price);
            return results.ToList();
        }

        public async Task<List<Product>> GetByQuantity(int quantity)
        {
            var results = await _db.LoadData<Product, int>("dbo.Product_GetByQuantity @Product_Quantity", quantity);
            return results.ToList();
        }

        public async Task<List<Product>> GetByType(string type)
        {
            var results = await _db.LoadData<Product, string>("dbo.Product_GetByType @Product_Type", type);
            return results.ToList();
        }

        public async Task Insert(Product entity)
        {
            await _db.SaveData("dbo.Product_Insert @Product_Name, @Product_Quantity, @Product_Price, @Product_Type", new { entity.Product_Name, entity.Product_Quantity, entity.Product_Price, entity.Product_Type });
        }

        public async Task Update(Product entity)
        {
            await _db.SaveData("dbo.Product_Update @Product_Id, @Product_Name, @Product_Quantity, @Product_Price, @Product_Type", entity);
        }
    }
}
