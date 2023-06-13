using DorksAndDice.DB.DBAccess;
using DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.DataRepositories.ProductRepositories.DiceCharacteristics
{
    public class TypeRepository<Type> : ITypeRepository<Type> where Type : Logic.Models.Product.DiceCharacteristics.Type
    {
        private readonly ISqlDataAccess _db;
        public TypeRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Type_Delete @Type_Id", id);
        }

        public async Task<List<Type>> GetAll()
        {
            var results = await _db.LoadData<Type, dynamic>("dbo.Type_GetAll", new { });
            return results.ToList();
        }

        public async Task<Type?> GetById(int id)
        {
            var results = await _db.LoadData<Type, dynamic>("dbo.Type_GetById @Type_Id", new { Type_Id = id });
            return results.FirstOrDefault();
        }

        public async Task<List<Type>> GetByType(string type)
        {
            var results = await _db.LoadData<Type, dynamic>("dbo.Type_GetByType @Dice_Type", new { Dice_Type = type });
            return results.ToList();
        }

        public async Task Insert(Type entity)
        {
            await _db.SaveData("dbo.Type_Insert @Dice_Type", new { entity.Dice_Type });
        }

        public async Task Update(Type entity)
        {
            await _db.SaveData("dbo.Type_Insert @Type_Id, @Dice_Type", entity );
        }
    }
}
