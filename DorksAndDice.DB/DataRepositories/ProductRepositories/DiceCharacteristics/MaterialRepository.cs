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
    public class MaterialRepository<Material> : IMaterialRepository<Material> where Material : Logic.Models.Product.DiceCharacteristics.Material
    {
        private readonly ISqlDataAccess _db;
        public MaterialRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Material_Delete @Material_Id", id);
        }

        public async Task<List<Material>> GetAll()
        {
            var results = await _db.LoadData<Material, dynamic>("dbo.Material_GetAll", new { });
            return results.ToList();
        }

        public async Task<Material?> GetById(int id)
        {
            var results = await _db.LoadData<Material, dynamic>("dbo.Material_GetById @Material_Id", new { Material_Id = id } );
            return results.FirstOrDefault();
        }

        public async Task<List<Material>> GetByMaterial(string material)
        {
            var results = await _db.LoadData<Material, dynamic>("dbo.Material_GetByMaterial @Dice_Material", new { Dice_Material = material });
            return results.ToList();
        }

        public async Task Insert(Material entity)
        {
            await _db.SaveData("dbo.Material_Insert @Dice_Material", new { entity.Dice_Material});
        }

        public async Task Update(Material entity)
        {
            await _db.SaveData("dbo.Material_Update @Material_Id, @Dice_Id", entity);
        }
    }
}
