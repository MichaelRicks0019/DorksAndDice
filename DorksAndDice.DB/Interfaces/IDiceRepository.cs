using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories
{
    public interface IDiceRepository<Dice> : IGenericRepository<Dice> where Dice : Logic.Models.Product.Dice
    {
        Task<Dice?> GetDiceById(int DiceId);
        Task<List<Dice>> GetDiceCharacteristicBy(string? Edge = null, string? Color = null, string? Material = null, string? Style = null, string? Type = null, string? Size = null);
        Task<Product?> GetProductById(int productId);
    }
}