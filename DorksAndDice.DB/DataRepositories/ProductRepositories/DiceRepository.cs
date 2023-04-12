using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces;
using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories
{
    public class DiceRepository<Dice> : IDiceRepository<Dice> where Dice : Logic.Models.Product.Dice
    {
        private readonly ISqlDataAccess _db;
        private Dice dice;

        public DiceRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Dice_Delete", id);
        }

        public async Task<List<Dice>> GetAll()
        {
            var results = await _db.LoadData<Dice, dynamic>("dbo.Dice_GetAll", new { });
            return results.ToList();
        }

        public async Task<List<Dice>> GetById(int id)
        {
            var results = await _db.LoadData<Dice, int>("dbo.Dice_GetById", id);
            return results.ToList();
        }

        public async Task<Dice?> GetDiceById(int DiceId)
        {
            var results = await _db.LoadData<Dice, int>("dbo.Dice_GetDiceById", DiceId);
            return results.FirstOrDefault();
        }

        public async Task<List<Dice>> GetDiceCharacteristicBy(string? Edge = null, string? Color = null, string? Material = null, string? Style = null, string? Type = null, string? Size = null)
        {
            var results = await _db.LoadData<Dice, dynamic>("Dice_GetDiceByCharacteristic @Edge, @Color, @Material, @Style, @Type, @Size", new { Edge = Edge, Color = Color, Material = Material, Style = Style, Type = Type, Size = Size });
            return results.ToList();
        }

        public async Task<Product?> GetProductById(int productId)
        {
            var results = await _db.LoadData<Product, int>("Dice_GetProductById", productId);
            return results.FirstOrDefault();
        }

        public async Task Insert(Dice entity)
        {
            await _db.SaveData("Dice_Insert @Product_Id, @Edge, @Color, @Material, @Style, @Type, @Size", new { Product_Id = entity.Product_Id, Edge = entity.Edge, Color = entity.Color, Material = entity.Material, Style = entity.Style, Type = entity.Type, Size = entity.Size });
        }

        public async Task Update(Dice entity)
        {
            await _db.SaveData("Dice_Insert @Product_Id, @Edge, @Color, @Material, @Style, @Type, @Size", entity);

        }
    }
}
