using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product;

namespace DorksAndDice.DB.Interfaces.ProductInterfaces
{
    public interface IDiceRepository<Dice> : IGenericRepository<Dice> where Dice : Logic.Models.Product.Dice
    {
        Task<List<Dice>> GetDiceCharacteristicBy(string? Edge = null, string? Color = null, string? Material = null, string? Style = null, string? Type = null, string? Size = null);
        Task<List<Dice>> GetByName(string name);
        Task<List<Dice>> GetByQuantity(int quantity);
        Task<List<Dice>> GetByPrice(decimal price);
    }
}