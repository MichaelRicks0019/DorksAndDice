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
    public class ShoppingCartRepository<ShoppingCartItems> : IShoppingCartsRepository<ShoppingCartItems> where ShoppingCartItems : Logic.Models.Shopping.ShoppingCartItems
    {
        private readonly ISqlDataAccess _db;

        public ShoppingCartRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task ClearCart(int shoppingCartId)
        {
            await _db.SaveData("ShoppingCarts_ClearCart @ShoppingCart_Id", shoppingCartId);
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("ShoppingCarts_Delete @Customer_Id", id);
        }

        public async  Task<List<ShoppingCartItems>> GetAll()
        {
            var results = await _db.LoadData<ShoppingCartItems, dynamic>("dbo.ShoppingCarts_GetAll", new { });
            return results.ToList();

        }

        public async Task<ShoppingCartItems?> GetById(int id)
        {
            var results = await _db.LoadData<ShoppingCartItems, dynamic>("dbo.ShoppingCarts_GetById @Customer_Id", new { Customer_Id = id });
            return results.FirstOrDefault();
        }

        public async Task<List<ShoppingCartItems>> GetByProductId(int productId)
        {
            var results = await _db.LoadData<ShoppingCartItems, dynamic>("dbo.ShoppingCarts_GetByProductId @Product_Id", new { Product_Id = productId });
            return results.ToList();
        }

        public async Task<List<ShoppingCartItems>> GetByQuantity(int quantity)
        {
            var results = await _db.LoadData<ShoppingCartItems, dynamic>("dbo.ShoppingCarts_GetByQuantity @Quantity", new { Quantity = quantity });
            return results.ToList();
        }

        public async Task<List<ShoppingCartItems>> GetByShoppingCartId(int shoppingCartId)
        {
            var results = await _db.LoadData<ShoppingCartItems, dynamic>("dbo.ShoppingCarts_GetByShoppingCartId @ShoppingCart_Id", new { ShoppingCart_Id = shoppingCartId });
            return results.ToList();
        }

        public async Task<decimal> GetTotal(int shoppingCartId)
        {
            var results = await _db.LoadData<decimal, dynamic>("dbo.ShoppingCarts_GetTotal @ShoppingCart_Id", new { ShoppingCart_Id = shoppingCartId });
            return results.FirstOrDefault();
        }

        public async Task Insert(ShoppingCartItems entity)
        {
            await _db.SaveData("dbo.ShoppingCarts_Insert @ShoppingCart_Id, @Product_Id, @Quantity", new { entity.ShoppingCart_Id, entity.Product_Id, entity.Quantity });
        }

        public async Task SendCartToOrders(int shoppingCartId)
        {
            await _db.SaveData("dbo.ShoppingCarts_SendCartToOrders @ShoppingCart_Id", shoppingCartId);
        }

        public async Task Update(ShoppingCartItems entity)
        {
            await _db.SaveData("dbo.ShoppingCarts_Update @Customer_Id, @ShoppingCart_Id, @Product_Id, @Quantity", entity);
        }
    }
}
