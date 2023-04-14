using DorksAndDice.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.DB.Interfaces.DiceCharacteristicInterfaces
{
    public interface ITypeRepository<Type> : IGenericRepository<Type> where Type : Logic.Models.Product.DiceCharacteristics.Type
    {
        Task<List<Type>> GetByType(string type);
    }
}
