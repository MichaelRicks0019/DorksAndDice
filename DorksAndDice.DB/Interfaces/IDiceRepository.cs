using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorksAndDice.Logic.Models.Product;

namespace DorksAndDice.Logic.Interfaces
{
    public interface IDiceRepository<Dice> : IGenericRepository<Dice>
    {
        public enum DiceType { Edge, Color, Material, Style, Type, Size};
        Task<List<Product>> GetProductById (int productId);
        Task<List<Dice>> GetDiceById (int DiceId);
        Task<List<Dice>> GetDiceCharacteristicBy(
            string Edge = "0",
            string Color = "0",
            string Material = "0",
            string Style = "0",
            string Type = "0",
            string Size = "0");
    }
}
