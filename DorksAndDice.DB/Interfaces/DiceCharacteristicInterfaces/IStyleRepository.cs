using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product.DiceCharacteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces
{
    public interface IStyleRepository<Style> : IGenericRepository<Style> where Style : Logic.Models.Product.DiceCharacteristics.Style
    {
        Task<List<Style>> GetByStyle(string style);
    }
}
