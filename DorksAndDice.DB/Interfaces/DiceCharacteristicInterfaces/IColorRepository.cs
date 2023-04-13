using DorksAndDice.Logic.Interfaces;
using DorksAndDice.Logic.Models.Product.DiceCharacteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces
{
    public interface IColorRepository<Color> : IGenericRepository<Color> where Color : Logic.Models.Product.DiceCharacteristics.Color
    {
        Task<List<Color>> GetByColor (string color);
    }
}
