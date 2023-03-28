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
        int ClearCart(int shoppingCartId);
        decimal GetTotal (int shoppingCartId);
        List<ShoppingCartItems> GetProducts (int shoppingCartId);
        void SendCartToOrders(int shoppingCartId);
        List<ShoppingCartItems> GetByShoppingCartId (int shoppingCartId);
        List<ShoppingCartItems> GetByProductId (int productId);
        List<ShoppingCartItems> GetByQuantity (int quantity);
    }
}
