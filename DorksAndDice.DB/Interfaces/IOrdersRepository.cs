using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces
{
    public interface IOrdersRepository : IGenericRepository<Orders>
    {
        List<Orders> GetByCustomerId (int customerId);

        List<Orders> GetByShoppingCartId(int shoppingCartId);

    }
}
