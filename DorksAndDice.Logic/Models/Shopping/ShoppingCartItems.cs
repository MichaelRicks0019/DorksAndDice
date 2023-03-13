using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.Shopping
{
    public class ShoppingCartItems
    {
        public int Customer_Id { get; set; }
        public int ShoppingCart_Id { get; set; }
        public int Product_Id { get; set; }
        public int Quantity { get; set; }
    }
}
