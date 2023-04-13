using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.ShoppingInterfaces
{
    public interface IShoppingCartsRepository<ShoppingCartItems> : IGenericRepository<ShoppingCartItems>
    {
        //Removes rows that have the shoppingCartId
        Task ClearCart(int shoppingCartId);
        Task<decimal> GetTotal(int shoppingCartId);
        Task SendCartToOrders(int shoppingCartId);
        Task<List<ShoppingCartItems>> GetByShoppingCartId(int shoppingCartId);
        Task<List<ShoppingCartItems>> GetByProductId(int productId);
        Task<List<ShoppingCartItems>> GetByQuantity(int quantity);
    }
}
