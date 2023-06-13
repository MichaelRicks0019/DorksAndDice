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
    public class SizeRepository<Size> : ISizeRepository<Size> where Size : Logic.Models.Product.DiceCharacteristics.Size
    {
        private readonly ISqlDataAccess _db;
        public SizeRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Size_Delete @Size_Id", id);
        }

        public async Task<List<Size>> GetAll()
        {
            var results = await _db.LoadData<Size, dynamic>("dbo.Size_GetAll", new { });
            return results.ToList();
        }

        public async Task<Size?> GetById(int id)
        {
            var results = await _db.LoadData<Size, dynamic>("dbo.Size_GetById @Size_Id", new { Size_Id = id });
            return results.FirstOrDefault();
        }

        public async Task<List<Size>> GetBySize(string size)
        {
            var results = await _db.LoadData<Size, dynamic>("dbo.Size_GetBySize @Dice_Size", new { Dice_Size = size });
            return results.ToList();
        }

        public async Task Insert(Size entity)
        {
            await _db.SaveData("dbo.Size_Insert @Dice_Size", new { entity.Dice_Size });
        }

        public async Task Update(Size entity)
        {
            await _db.SaveData("dbo.Size_Update @Size_Id, @Dice_Size", entity);
        }
    }
}
