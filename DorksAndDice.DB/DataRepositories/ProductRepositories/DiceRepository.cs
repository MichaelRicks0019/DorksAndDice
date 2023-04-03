using DorksAndDice.DB.DBAccess;
using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories
{
    public class DiceRepository<Dice> : IDiceRepository<Dice> where Dice: Logic.Models.Product.Dice
    {
        private readonly ISqlDataAccess _db;

        public DiceRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task Delete(int id)
        {
            return _db.SaveData("Dice_Delete", id);
        }

        public Task<List<Dice>> GetAll()
        {
            return _db.LoadData<Dice, dynamic>("Dice_GetAll", new { });
        }

        public Task<List<Dice>> GetById(int id)
        {
            return _db.LoadData<Dice, int>("Dice_GetById", id);
        }

        public Task<List<Dice>> GetDiceById(int DiceId)
        {
            return _db.LoadData<Dice, int>("Dice_GetDiceById", DiceId);
        }

        public Task<List<Dice>> GetDiceCharacteristicBy(string Edge = "0", string Color = "0", string Material = "0", string Style = "0", string Type = "0", string Size = "0")
        {
            return _db.LoadData<Dice, string>("Dice_GetDiceCharacteristicBy @Edge, @Color, @Material, @Style, @Type, @Size", new { Edge = Edge, Color = Color, Material = Material, Style = Style, Type = Type, Size = Size });
        }

        public Task<List<Product>> GetProductById(int productId)
        {
            return _db.LoadData<Product, int>("Dice_GetProductById", productId);
        }

        public Task Insert(Dice entity)
        {
            return _db.SaveData("Dice_Insert @Product_Id, @Edge, @Color, @Material, @Style, @Type, @Size", new { entity.Product_Id, entity.Edge, entity.Color, entity.Material, entity.Style, entity.Type, entity.Size });
        }

        public Task Update(Dice entity)
        {
            return _db.SaveData("Dice_Insert @Product_Id, @Edge, @Color, @Material, @Style, @Type, @Size", entity);

        }
    }
}
