using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.Shopping
{
    public class Orders
    {
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }
        public int ShoppingCart_Id { get; set; } 
    }
}
