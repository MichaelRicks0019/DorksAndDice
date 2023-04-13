using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product.DiceCharacteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces
{
    public interface IMaterialRepository<Material> : IGenericRepository<Material> where Material : Logic.Models.Product.DiceCharacteristics.Material
    {
        Task<List<Material>> GetByMaterial(string material);
    }
}
