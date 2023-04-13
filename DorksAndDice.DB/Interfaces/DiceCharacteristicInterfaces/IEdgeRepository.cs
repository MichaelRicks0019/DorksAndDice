using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product.DiceCharacteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces
{
    public interface IEdgeRepository<Edge> : IGenericRepository<Edge> where Edge : Logic.Models.Product.DiceCharacteristics.Edge
    {
        Task<List<Edge>> GetByEdge(string edge);
    }
}
