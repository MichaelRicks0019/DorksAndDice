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
    public class EdgeRepository<Edge> : IEdgeRepository<Edge> where Edge : Logic.Models.Product.DiceCharacteristics.Edge
    {
        private readonly ISqlDataAccess _db;
        public EdgeRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task Delete(int id)
        {
            await _db.SaveData("dbo.Edge_Delete @Edge_Id", id);
        }

        public async Task<List<Edge>> GetAll()
        {
            var results = await _db.LoadData<Edge, dynamic>("dbo.Edge_GetAll", new { });
            return results.ToList();
        }

        public async Task<List<Edge>> GetByEdge(string edge)
        {
            var results = await _db.LoadData<Edge, dynamic>("dbo.Edge_GetByEdge @Dice_Edge", new { Dice_Edge = edge });
            return results.ToList();
        }

        public async Task<Edge?> GetById(int id)
        {
            var results = await _db.LoadData<Edge, dynamic>("dbo.Edge_GetById @Edge_Id", new { Edge_Id = id });
            return results.FirstOrDefault();
        }

        public async Task Insert(Edge entity)
        {
            await _db.SaveData("dbo.Edge_Insert @Dice_Edge", new {entity.Dice_Edge});
        }

        public async Task Update(Edge entity)
        {
            await _db.SaveData("dbo.Edge_Update @Edge_Id, @Dice_Edge", entity );
        }
    }
}
