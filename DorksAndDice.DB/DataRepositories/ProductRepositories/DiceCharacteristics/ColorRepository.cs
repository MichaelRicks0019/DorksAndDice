using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces;
using DorksAndDice.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories.DiceCharacteristics
{
    public class ColorRepository<Color> : IColorRepository<Color> where Color : Logic.Models.Product.DiceCharacteristics.Color
    {
        private readonly ISqlDataAccess _db;
        public ColorRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Color_Delete @Color_Id", id);
        }

        public async Task<List<Color>> GetAll()
        {
            var results = await _db.LoadData<Color, dynamic>("dbo.Color_GetAll", new { });
            return results.ToList();
        }

        public async Task<List<Color>> GetByColor(string color)
        {
            var results = await _db.LoadData<Color, string>("dbo.Color_GetByColor @Dice_Color", color);
            return results.ToList();
        }

        public async Task<Color?> GetById(int id)
        {
            var results = await _db.LoadData<Color, int>("dbo.Color_GetById @Color_Id", id);
            return results.FirstOrDefault();
        }

        public async Task Insert(Color entity)
        {
            await _db.SaveData("dbo.Color_Insert @Dice_Color", new { entity.Dice_Color });
        }

        public async Task Update(Color entity)
        {
            await _db.SaveData("dbo.Color_Update @Color_Id, @Dice_Color", entity);
        }
    }
}