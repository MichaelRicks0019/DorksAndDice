using DorksAndDice.Logic.Models.Product;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories
{
    public interface IDiceRepository<Dice> where Dice : Logic.Models.Product.Dice
    {
        Task Delete(int id);
        Task<List<Dice>> GetAll();
        Task<List<Dice>> GetById(int id);
        Task<Dice?> GetDiceById(int DiceId);
        Task<List<Dice>> GetDiceCharacteristicBy(string Edge = "0", string Color = "0", string Material = "0", string Style = "0", string Type = "0", string Size = "0");
        Task<Product?> GetProductById(int productId);
        Task Insert(Dice entity);
        Task Update(Dice entity);
    }
}