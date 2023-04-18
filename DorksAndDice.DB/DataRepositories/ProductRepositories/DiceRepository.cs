using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces;
using DorksAndDice.DB.Interfaces.ProductInterfaces;
using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories
{
    public class DiceRepository<Dice> : IDiceRepository<Dice> where Dice : Logic.Models.Product.Dice
    {
        private readonly ISqlDataAccess _db;

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

        public async Task<Dice?> GetById(int id)
        {
            var results = await _db.LoadData<Dice, int>("dbo.Dice_GetById @Dice_Id", id);
            return results.FirstOrDefault();
        }

        public async Task<List<Dice>> GetByName(string name)
        {
            var results = await _db.LoadData<Dice, string>("dbo.Dice_GetByName @Dice_Name", name);
            return results.ToList();
        }

        public async Task<List<Dice>> GetByPrice(decimal price)
        {
            var results = await _db.LoadData<Dice, decimal>("dbo.Dice_GetByPrice @Dice_Price", price);
            return results.ToList();
        }

        public async Task<List<Dice>> GetByQuantity(int quantity)
        {
            var results = await _db.LoadData<Dice, decimal>("dbo.Dice_GetByQuantity @Dice_Quantity", quantity);
            return results.ToList();
        }

        public async Task<List<Dice>> GetDiceCharacteristicBy(string? Edge = null, string? Color = null, string? Material = null, string? Style = null, string? Type = null, string? Size = null)
        {
            var results = await _db.LoadData<Dice, dynamic>("Dice_GetDiceByCharacteristic @Edge, @Color, @Material, @Style, @Type, @Size", new { Edge = Edge, Color = Color, Material = Material, Style = Style, Type = Type, Size = Size });
            return results.ToList();
        }

        public async Task Insert(Dice entity)
        {
            await _db.SaveData("Dice_Insert @Dice_Name, @Dice_Quantity, @Dice_Price, @Edge, @Color, @Material, @Style, @Type, @Size", new { entity.Dice_Name, entity.Dice_Quantity, entity.Dice_Price, entity.Edge, entity.Color, entity.Material, entity.Style, entity.Type, entity.Size });
        }

        public async Task Update(Dice entity)
        {
            await _db.SaveData("Dice_Insert @Dice_Id, @Dice_Name, @Dice_Quantity, @Dice_Price, @Edge, @Color, @Material, @Style, @Type, @Size", entity);

        }
    }
}
