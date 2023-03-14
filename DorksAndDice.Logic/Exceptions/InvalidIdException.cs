﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    [Serializable]
   public class InvalidIdException : Exception
   {
            public InvalidIdException() : base("Must enter valid Id")
            {

            }

            public InvalidIdException(string messageValue) : base(messageValue)
            {

            }

            public InvalidIdException(string messageValue, Exception inner) : base(messageValue, inner)
            {

            }
   }
}
