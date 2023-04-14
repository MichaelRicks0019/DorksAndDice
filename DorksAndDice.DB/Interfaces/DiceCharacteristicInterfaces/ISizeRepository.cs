using DorksAndDice.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces
{
    public interface ISizeRepository<Size> : IGenericRepository<Size> where Size : Logic.Models.Product.DiceCharacteristics.Size
    {
        Task<List<Size>> GetBySize(string size);
    }
}
