using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces
{
    public interface IShoppingCartsRepository : IGenericRepository<ShoppingCartItems>
    {
        //Removes rows that have the shoppingCartId
        Task<int> ClearCart(int shoppingCartId);
        Task<decimal> GetTotal (int shoppingCartId);
        Task<List<ShoppingCartItems>> GetProducts (int shoppingCartId);
        Task SendCartToOrders(int shoppingCartId);
        Task<List<ShoppingCartItems>> GetByShoppingCartId (int shoppingCartId);
        Task<List<ShoppingCartItems>> GetByProductId (int productId);
        Task<List<ShoppingCartItems>> GetByQuantity (int quantity);
    }
}
