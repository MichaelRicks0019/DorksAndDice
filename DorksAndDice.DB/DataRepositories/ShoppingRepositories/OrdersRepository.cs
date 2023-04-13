using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.ShoppingInterfaces;
using DorksAndDice.Logic.Models.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ShoppingRepositories
{
    public class OrdersRepository<Orders> : IOrdersRepository<Orders> where Orders : Logic.Models.Shopping.Orders
    {
        private readonly ISqlDataAccess _db;

        public OrdersRepository (ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Orders_Delete @Order_Id", id);
        }

        public async Task<List<Orders>> GetAll()
        {
            var results = await _db.LoadData<Orders, dynamic>("dbo.Orders_GetAll", new { });
            return results.ToList();
        }

        public async Task<List<Orders>> GetByCustomerId(int customerId)
        {
            var results = await _db.LoadData<Orders, int>("dbo.Orders_GetByCustomerId @Customer_Id", customerId);
            return results.ToList();        }

        public async Task<Orders?> GetById(int id)
        {
            var results = await _db.LoadData<Orders, int>("dbo.Orders_GetById @Order_Id", id);
            return results.FirstOrDefault();
        }

        public async Task<List<Orders>> GetByShoppingCartId(int shoppingCartId)
        {
            var results = await _db.LoadData<Orders, int>("dbo.Orders_GetByShoppingCartId @ShoppingCart_Id", shoppingCartId);
            return results.ToList();
        }

        public async Task Insert(Orders entity)
        {
            await _db.SaveData("dbo.Orders_Insert @Customer_Id, @ShoppingCart_Id", new { entity.Customer_Id, entity.ShoppingCart_Id });
        }

        public async Task Update(Orders entity)
        {
            await _db.SaveData("dbo.Orders_Update @Order_Id, @Customer_Id, @ShoppingCart_Id", entity);
        }
    }
}
