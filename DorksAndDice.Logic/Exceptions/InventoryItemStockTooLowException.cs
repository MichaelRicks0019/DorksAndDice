using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorksAndDice.Logic.Exceptions
{
    public class NegativeQuantityException : Exception
    {
        public NegativeQuantityException() : base("Quantity cannot be below 0")
        {

        }

        public NegativeQuantityException(string messageValue) : base(messageValue)
        {

        }

        public NegativeQuantityException(string messageValue, Exception inner) : base(messageValue, inner)
        {

        }
    }
}
