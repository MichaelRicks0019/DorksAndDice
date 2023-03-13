using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Models.Product
{
    public class Product
    {
        public int Dice_Id { get; set; }
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Product_Type { get; set; }
    }
}
