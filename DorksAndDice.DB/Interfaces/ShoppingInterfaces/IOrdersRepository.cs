using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.ShoppingInterfaces
{
    public interface IOrdersRepository<Orders> : IGenericRepository<Orders>
    {
        Task<List<Orders>> GetByCustomerId(int customerId);
        Task<List<Orders>> GetByShoppingCartId(int shoppingCartId);

    }
}
