using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorksAndDice.Logic.Models.Product;

namespace DorksAndDice.Logic.Interfaces
{
    public interface IDiceRepository : IGenericRepository<Dice>
    {
        Product GetProductById (int productId);
        Dice GetDiceById (int DiceId);
        List<Dice> GetDiceCharacteristicBy(
            string Edge = "0",
            string Color = "0",
            string Material = "0",
            string Style = "0",
            string Type = "0",
            string Size = "0");
    }
}
