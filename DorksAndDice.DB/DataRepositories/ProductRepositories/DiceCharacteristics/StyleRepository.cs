using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces;
using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product.DiceCharacteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories.DiceCharacteristics
{
    public class StyleRepository<Style> : IStyleRepository<Style> where Style : Logic.Models.Product.DiceCharacteristics.Style
    {
        private readonly ISqlDataAccess _db;
        public StyleRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Style_Delete @Style_Delete", id);
        }

        public async Task<List<Style>> GetAll()
        {
            var results = await _db.LoadData<Style, dynamic>("dbo.Style_GetAll", new { });
            return results.ToList();
        }

        public async Task<Style?> GetById(int id)
        {
            var results = await _db.LoadData<Style, int>("dbo.Style_GetById @Style_Id", id);
            return results.FirstOrDefault();
        }

        public async Task<List<Style>> GetByStyle(string style)
        {
            var results = await _db.LoadData<Style, string>("dbo.Style_GetByStyle @Dice_Style", style);
            return results.ToList();
        }

        public async Task Insert(Style entity)
        {
            await _db.SaveData("dbo.Style_Insert @Dice_Style", new { entity.Dice_Style });
        }

        public async Task Update(Style entity)
        {
            await _db.SaveData("dbo.Style_Update @Style_Id, @Dice_Style", entity);
        }
    }
}
